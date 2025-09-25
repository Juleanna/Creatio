#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Скрипт для импорта данных калькуляции из Excel в Creatio
"""

import pandas as pd
import json
import requests
from typing import List, Dict, Any

class CreatioExcelImporter:
    def __init__(self, excel_file_path: str, creatio_service_url: str = None):
        """
        Инициализация импортёра

        Args:
            excel_file_path: путь к Excel файлу
            creatio_service_url: URL сервиса Creatio (если есть)
        """
        self.excel_file_path = excel_file_path
        self.creatio_service_url = creatio_service_url

    def read_excel_data(self) -> List[Dict[str, Any]]:
        """
        Чтение данных из Excel файла

        Returns:
            List[Dict]: Список строк данных
        """
        try:
            # Читаем Excel файл
            df = pd.read_excel(self.excel_file_path, sheet_name='Лист1', skiprows=2, engine='openpyxl')

            # Переименовываем колонки для удобства
            # Сначала посмотрим какие колонки есть
            print("Колонки в файле:", list(df.columns))

            # Найдем колонку с числовым значением (стоимость)
            cost_column = None
            for col in df.columns:
                if str(col).isdigit() or (isinstance(col, (int, float)) and col > 1000):
                    cost_column = col
                    break

            if cost_column is None:
                # Попробуем найти колонку по содержимому
                for col in df.columns:
                    if df[col].dtype in ['int64', 'float64'] and df[col].sum() > 10000:
                        cost_column = col
                        break

            column_mapping = {
                'Unnamed: 0': 'Number',
                'Unnamed: 1': 'Name',
                'Unnamed: 2': 'Code',
                'Unnamed: 3': 'Unit',
                'Unnamed: 4': 'Quantity',
                'Unnamed: 5': 'Coefficient',
                'Unnamed: 6': 'AdjustedQuantity',
                'Unnamed: 8': 'SupplyDocuments'
            }

            if cost_column:
                column_mapping[cost_column] = 'TotalCost'

            # Применяем переименование колонок
            df = df.rename(columns=column_mapping)

            # Убираем пустые строки
            df = df.dropna(subset=['Name'])

            # Преобразуем в список словарей
            data = []
            production_volume = 30000  # Объём производства из заголовка

            for index, row in df.iterrows():
                if pd.notna(row['Name']) and row['Name'] != 'Итого':
                    item = {
                        'Name': str(row['Name']).strip(),
                        'Code': str(row['Code']).strip() if pd.notna(row['Code']) else '',
                        'Unit': str(row['Unit']).strip() if pd.notna(row['Unit']) else 'кг',
                        'Quantity': float(row['Quantity']) if pd.notna(row['Quantity']) else 0.0,
                        'Coefficient': float(row['Coefficient']) if pd.notna(row['Coefficient']) else 1.0,
                        'UnitPrice': float(row['TotalCost']) / production_volume if pd.notna(row['TotalCost']) and row['TotalCost'] > 0 else 0.0,
                        'ProductionVolume': production_volume,
                        'SupplyDocuments': str(row['SupplyDocuments']).strip() if pd.notna(row['SupplyDocuments']) else ''
                    }
                    data.append(item)

            return data

        except Exception as e:
            print(f"Ошибка при чтении Excel файла: {e}")
            return []

    def generate_json_output(self) -> None:
        """
        Генерация JSON файла с данными для импорта
        """
        data = self.read_excel_data()

        if not data:
            print("Нет данных для экспорта")
            return

        # Сохраняем в JSON файл
        output_file = 'calculation_data.json'

        export_data = {
            'ProductName': 'Калькуляционная карта изготовления изделия',
            'ProductCode': 'CALC-001',
            'ProductionVolume': 30000,
            'Ingredients': data,
            'Summary': {
                'TotalIngredients': len(data),
                'TotalCost': sum(item['UnitPrice'] * item['Quantity'] * item['Coefficient'] * item['ProductionVolume'] for item in data)
            }
        }

        with open(output_file, 'w', encoding='utf-8') as f:
            json.dump(export_data, f, ensure_ascii=False, indent=2)

        print(f"Данные экспортированы в {output_file}")
        print(f"Обработано ингредиентов: {len(data)}")
        print(f"Общая стоимость: {export_data['Summary']['TotalCost']:.2f}")

        # Выводим первые несколько записей для проверки
        print("\nПримеры данных:")
        for i, item in enumerate(data[:5]):
            print(f"{i+1}. {item['Name']} ({item['Code']}) - {item['Quantity']} {item['Unit']}")

    def generate_sql_inserts(self) -> None:
        """
        Генерация SQL скриптов для вставки данных
        """
        data = self.read_excel_data()

        if not data:
            print("Нет данных для генерации SQL")
            return

        sql_file = 'insert_calculation_data.sql'

        with open(sql_file, 'w', encoding='utf-8') as f:
            f.write("-- Скрипт для импорта данных калькуляции\n")
            f.write("-- Сгенерирован автоматически\n\n")

            # Создаем продукт
            f.write("-- Создание продукта\n")
            f.write("INSERT INTO Product (Id, Name, Code, Unit, BasePrice) VALUES\n")
            f.write("(NEWID(), 'Калькуляционная карта изготовления изделия', 'CALC-001', 'шт', 0);\n\n")

            # Получаем ID продукта
            f.write("DECLARE @ProductId UNIQUEIDENTIFIER = (SELECT Id FROM Product WHERE Code = 'CALC-001');\n\n")

            # Создаем ингредиенты
            f.write("-- Создание ингредиентов\n")
            for i, item in enumerate(data):
                f.write(f"INSERT INTO Ingredient (Id, Name, Code, Unit, UnitPrice, Coefficient, SupplyDocuments) VALUES\n")
                f.write(f"(NEWID(), N'{item['Name']}', '{item['Code']}', '{item['Unit']}', {item['UnitPrice']}, {item['Coefficient']}, N'{item['SupplyDocuments']}');\n\n")

                # Создаем связь продукт-ингредиент
                f.write(f"INSERT INTO ProductCalculation (Id, ProductId, IngredientId, Quantity, Coefficient, AdjustedQuantity, TotalCost, ProductionVolume) VALUES\n")
                adjusted_qty = item['Quantity'] * item['Coefficient']
                total_cost = adjusted_qty * item['ProductionVolume'] * item['UnitPrice']
                f.write(f"(NEWID(), @ProductId, (SELECT Id FROM Ingredient WHERE Code = '{item['Code']}'), {item['Quantity']}, {item['Coefficient']}, {adjusted_qty}, {total_cost}, {item['ProductionVolume']});\n\n")

        print(f"SQL скрипт сгенерирован: {sql_file}")

    def print_analysis(self) -> None:
        """
        Печать анализа данных
        """
        data = self.read_excel_data()

        if not data:
            print("Нет данных для анализа")
            return

        print("=== АНАЛИЗ КАЛЬКУЛЯЦИИ ===\n")

        total_cost = 0
        print(f"{'№':<3} {'Ингредиент':<40} {'Кол-во':<8} {'Коэф.':<6} {'Скор.кол':<8} {'Цена/ед':<12} {'Стоимость':<12}")
        print("-" * 95)

        for i, item in enumerate(data, 1):
            adjusted_qty = item['Quantity'] * item['Coefficient']
            line_cost = adjusted_qty * item['ProductionVolume'] * item['UnitPrice']
            total_cost += line_cost

            print(f"{i:<3} {item['Name'][:39]:<40} {item['Quantity']:<8.2f} {item['Coefficient']:<6.2f} {adjusted_qty:<8.2f} {item['UnitPrice']:<12.2f} {line_cost:<12.2f}")

        print("-" * 95)
        print(f"{'ИТОГО:':<67} {total_cost:<12.2f}")
        print(f"\nОбъём производства: {data[0]['ProductionVolume']:,} единиц")
        print(f"Количество ингредиентов: {len(data)}")

def main():
    """Главная функция"""
    excel_file = "ККУ 30000 2.xlsx"

    try:
        importer = CreatioExcelImporter(excel_file)

        print("Выберите действие:")
        print("1. Анализ данных")
        print("2. Экспорт в JSON")
        print("3. Генерация SQL скриптов")
        print("4. Всё вместе")

        choice = input("Ваш выбор (1-4): ").strip()

        if choice == "1":
            importer.print_analysis()
        elif choice == "2":
            importer.generate_json_output()
        elif choice == "3":
            importer.generate_sql_inserts()
        elif choice == "4":
            importer.print_analysis()
            print("\n" + "="*50 + "\n")
            importer.generate_json_output()
            print("\n" + "="*50 + "\n")
            importer.generate_sql_inserts()
        else:
            print("Неверный выбор")

    except Exception as e:
        print(f"Ошибка: {e}")

if __name__ == "__main__":
    main()