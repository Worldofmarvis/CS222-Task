using System;

class CurrencyConverter{
    public static void Main(string[] args){
        Console.Write("Enter amount in USD: ");
        double amountInUSD = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter exchange rate from USD to EUR: ");
        double exchangeRate = Convert.ToDouble(Console.ReadLine());
        double amountInEUR = amountInUSD * exchangeRate;
        Console.WriteLine($"Amount in EUR: {amountInEUR:F2}");

    }


}