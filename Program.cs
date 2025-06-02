using System;
using System.Collections.Generic;
using System.Linq;
using static Name.Unit;
using static Name.Factory;
using static Name.Tank;
using System.Reflection;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reader.LoadTanksFromJson("tanks.json");            
            //lab1();
            lab2();

        }
        static void lab2()
        {
            System.Console.WriteLine("list of all deals: ");
            Deal[]? deals = Reader.LoadDealsFromJson("JSON_sample_1.json");
            System.Console.WriteLine("list of 5 first deals sorted by date with at least 100 sum:");
            Deal[]? sorted_deals = Deal.GetNumberOfDeals(deals);
            Deal.dealprinter(sorted_deals);

            System.Console.WriteLine("sum of deals sorted by month: ");
            Deal[]? dealsbymonth = Deal.GetSumOfDealsByMonth(deals);
            Deal.dealprinter(dealsbymonth);
        }
        static void lab1()
        {
            // Создание экземпляров классов
            var tanks = GetTanks();
            var factories = GetFactories();
            var units = GetUnits();
            // Вывод всех резервуаров с именами цехов и фабрик
            Console.WriteLine("Список резервуаров:");
            foreach (var tank in tanks)
            {
                var unit = units.FirstOrDefault(u => u.Id == tank.UnitId);
                var factory = factories.FirstOrDefault(f => f.Id == unit?.Id);
                Console.WriteLine($"Резервуар: {tank.Name}, Описание: {tank.Description}, " +
                                    $"Цех: {unit?.Name}, Фабрика: {factory?.Name}");
            }

            // Вывод общей суммы загрузки всех резервуаров
            var totalVolume = GetTotalVolume(tanks);
            Console.WriteLine($"\nОбщая сумма загрузки всех резервуаров: {totalVolume}");

            // Поиск резервуара по имени
            Console.WriteLine("\nВведите название резервуара для поиска:");
            string? searchName = Console.ReadLine();
            var foundTank = FindTankByName(tanks, searchName);
            if (foundTank != null)
            {
                var unit = units.FirstOrDefault(u => u.Id == foundTank.UnitId);
                var factory = factories.FirstOrDefault(f => f.Id == unit?.Id);
                Console.WriteLine($"Найденный резервуар: {foundTank.Name}, Описание: {foundTank.Description}, " +
                                    $"Цех: {unit?.Name}, Фабрика: {factory?.Name}");
            }
            else
            {
                Console.WriteLine("Резервуар не найден.");
            }

        }

    }
}





