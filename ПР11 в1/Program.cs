using System;
using System.Collections.Generic;

// Базовий клас відрізка дороги
class RoadSegment
{
    public double Length { get; set; } // Довжина відрізка
    public double FuelCostPerKm { get; set; } // Витрати бензину на км

    // Метод для розрахунку вартості проїзду
    public virtual double MovementPrice()
    {
        return Length * FuelCostPerKm;
    }
}

// Клас для безкоштовного відрізка дороги
class FreeSegment : RoadSegment
{
    // Перевизначений метод для безкоштовного відрізка
    public override double MovementPrice()
    {
        return base.MovementPrice(); // Вартість = витрати бензину * довжина відрізку
    }
}

// Клас для платного відрізка дороги
class TollSegment : RoadSegment
{
    public double FixedTariff { get; set; } // Фіксований тариф

    // Перевизначений метод для платного відрізка
    public override double MovementPrice()
    {
        // Вартість = витрати бензину * довжина відрізку + фіксований тариф
        return base.MovementPrice() + FixedTariff;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення списку об'єктів RoadSegment різного виду
        List<RoadSegment> roadSegments = new List<RoadSegment>
        {
            new FreeSegment { Length = 100, FuelCostPerKm = 0.2 },
            new TollSegment { Length = 150, FuelCostPerKm = 0.25, FixedTariff = 5 },
            new FreeSegment { Length = 80, FuelCostPerKm = 0.18 },
            new TollSegment { Length = 120, FuelCostPerKm = 0.22, FixedTariff = 3 }
        };

        // Розрахунок загальної вартості проїзду всіх сегментів
        double totalCost = 0;
        foreach (var segment in roadSegments)
        {
            totalCost += segment.MovementPrice();
        }

        Console.WriteLine($"Загальна вартість проїзду: {totalCost}");
    }
}
