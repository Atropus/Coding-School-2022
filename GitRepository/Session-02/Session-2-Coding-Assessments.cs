using System;

public class Session2
{

    public static void Main()
    {


        //1.
        Console.WriteLine("1.");
        Console.WriteLine("Hello Mantikidis Dimitris");
        Console.WriteLine("");

        //2.
        Console.WriteLine("2.");
        int a = 10;
        int b = 5;
        
        int sum = a + b;
        int div = a / b;
        Console.WriteLine(sum);
        Console.WriteLine(div);
        Console.WriteLine("");


        //3.
        Console.WriteLine("3.");
        Console.WriteLine(-1 + 5 * 6);
        
        Console.WriteLine(38 + 5 % 7);
        
        decimal x = 14 + -3 * 6 / (decimal)7;
        Console.WriteLine(x);

        double sqrta = Math.Sqrt(7);
        Console.WriteLine(2 + 13 / (decimal)6 * 6 + (decimal)sqrta);
        
        double powa = Math.Pow(6, 4);
        double powb = Math.Pow(5, 7);
        Console.WriteLine((decimal)powa + (decimal)powb / (decimal)9 % 4);
        Console.WriteLine("");

        //4.
        Console.WriteLine("4.");
        int age = 20;
        string gender = "female";
        Console.WriteLine("You are "+gender+" and look younger than "+age);
        Console.WriteLine("");

        //5.
        Console.WriteLine("5.");
        decimal sec = 45678;
        decimal minutes = sec / 60;
        decimal hours = sec / 3600;
        decimal days = sec / 86400;
        decimal years = sec / 31536000;
        Console.WriteLine("45678 seconds are:");
        Console.WriteLine("Minutes: " + minutes);
        Console.WriteLine("Hours: " + hours);
        Console.WriteLine("Days: " + days);
        Console.WriteLine("Years: " + years);
        Console.WriteLine("");

        //6.
        Console.WriteLine("6.");
        int timeinseconds = 45678;
        TimeSpan Interval = TimeSpan.FromSeconds(timeinseconds);
        Console.WriteLine("45678 seconds are:");
        Console.WriteLine((Interval.TotalMinutes) + " Minutes");
        Console.WriteLine((Interval.TotalHours) + "Hours");
        Console.WriteLine((Interval.TotalDays) + "Days");
        Console.WriteLine((Interval.TotalDays / (float)365) + "Years");
        Console.WriteLine("");

        //7.
        Console.WriteLine("7.");
        int tempc = 27;
        double tempf = tempc * (9 / 5) + 32;
        double tempk = tempc + 273.15;
        Console.WriteLine("If we have 27 Celsius then:");
        Console.WriteLine("Fahrenheit: "+ tempf);
        Console.WriteLine("Kelvin: "+tempk);
        Console.WriteLine("");


        Console.ReadLine();
           
    }
} 
    