using System;
namespace StaticExercise
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine($"72° Fahrenheit is  {TempConverter.FahrenheitToCelsius(72):0.0}° Celsius");
            Console.WriteLine($"31° Celsius is {TempConverter.CelsiusToFahrenheit(31):0.0}° Fahrenheit");
        }
    }
}
