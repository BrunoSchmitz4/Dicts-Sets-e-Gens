using System;
using System.Collections.Generic;
using System.Globalization;

namespace DictAppOne.Services
{
    class CalculationService
    {
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Square(double x)
        {
            return x * x;
        }

        public static void ShowMax(double x, double y)
        {
            Console.WriteLine($"{((x > y) ? x : y)} é maior que {((x < y) ? x : y)}");
        }

        public static void ShowSum(double x, double y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public static void ShowMult(double x, double y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public static void ShowDiv(double x, double y)
        {
            Console.WriteLine($"{x} / {y} = {(x / y).ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void ShowSub(double x, double y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public static void ExplosionMethods(double x, double y)
        {
            ShowSum(x, y);
            ShowMult(x, y);
            ShowDiv(x, y);
            ShowSub(x, y);
            ShowMax(x, y);
        }
    }
}
