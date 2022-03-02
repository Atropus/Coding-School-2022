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

        int age = 20;
        string gender = "female";
        Console.WriteLine("You are "+gender+" and look younger than "+age);
        Console.WriteLine("");

        //4.
        Console.WriteLine("4.");
        decimal sec = 45678;
        decimal minutes = sec / 60;
        decimal hours = sec / 3600;
        decimal days = sec / 86400;
        decimal years = sec / 31536000;
        Console.WriteLine("Minutes: " + minutes);
        Console.WriteLine("Hours: " + hours);
        Console.WriteLine("Days: " + days);
        Console.WriteLine("Years: " + years);
        Console.WriteLine("");

        //6.
        Console.WriteLine("");

        //7.
        Console.WriteLine("7.");
        decimal tempc = 27;
        decimal tempk = tempc * 9 / 5 + 32;
        //decimal tempf = ;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");


        Console.ReadLine();
           
    }
} 
    