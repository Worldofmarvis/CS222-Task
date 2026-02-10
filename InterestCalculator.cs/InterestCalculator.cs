using System;

class InterestCalculator
{
       public static void Main()
    {
        Console.Write("Enter principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate of interest: ");
        double annualRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time in years: ");
        double time = Convert.ToDouble(Console.ReadLine());

        double interest = (principal * annualRate * time) / 100;

        Console.Write($"Simple Interest: {interest:F2}");




    }
    

}
