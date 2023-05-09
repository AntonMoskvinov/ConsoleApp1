using System;

static class Program
{
    private static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input.Remove(input.Length - 1).Trim());
            switch (char.ToLower(input[input.Length - 1]))
            {
                case 'C':
                    Console.WriteLine(TemperatureConverter.ToFahrenheit(number) + " F");
                    break;
                case 'F':
                    Console.WriteLine(TemperatureConverter.ToCelsius(number) + " C");
                    break;
                default:
                    Console.WriteLine("Вы не ввели единицы измерения (C или F)");
                    break;
            }
        }
    }
}
public static class TemperatureConverter
{
    public static int ToCelsius(int fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
    public static int ToFahrenheit(int celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}