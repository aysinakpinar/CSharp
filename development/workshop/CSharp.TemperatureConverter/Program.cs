// TemperatureConverter.cs
using System;

namespace CSharp.TemperatureConverter
{

    public class TemperatureConverter
    {
        public static void Main(string[] args)
        {
            TemperatureConverter converter = new TemperatureConverter();

            double fahrenheit = 60.0;
            Console.WriteLine($"{fahrenheit} in fahrenheit = {converter.ToCelsius(fahrenheit)} in celsius");

            double celsius = 27.0;
            Console.WriteLine($"{celsius} in celsius = {converter.ToFahrenheit(celsius)} in fahrenheit");
        }

        public double ToCelsius(double fahrenheit)
        {
            double factor = 5.0 / 9.0;
            return (fahrenheit - 32) * factor;
        }

        public double ToFahrenheit(double celsius)
        {
            double factor = 9.0 / 5.0;
            return celsius * factor + 32;
        }
    }
}