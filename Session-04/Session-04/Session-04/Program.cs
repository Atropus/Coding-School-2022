using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class Program
    {
        static void Main(string[] args) {
            
            string es = string.Empty;
            //1.
            Console.WriteLine("1.");
            string myName = "Mantikidis Dimitris";
            Console.WriteLine("My name is: "+ myName);
            Console.WriteLine("In Reverse it is: " + Class1.ReverseString(myName));

            //2. 
            Console.WriteLine("2.");
            Console.WriteLine("Enter an integer number to calculate the sum and product of 1 to n. : ");
            Console.Write("Enter number : ");
            string inputNumber2 = Console.ReadLine();
            var c2 = new Class2();
            int n1 = Convert.ToInt32(inputNumber2);
            Console.WriteLine("The sum is :" + c2.GetSum(n1));
            Console.WriteLine("The Product is :" + c2.GetProduct(n1));

            //3.
            Console.WriteLine("3.");
            Console.WriteLine("Enter an integer number to to find all the prime numbers from 1 to n : ");
            Console.Write("Enter number : ");
            string inputNumber3 = Console.ReadLine();
            var c3 = new Class3();
            int n3 = Convert.ToInt32(inputNumber3);
            Console.WriteLine("It is a prime :" + c3.IsPrime(n3));

            //4.
            int[] Array1 = { 2, 4, 9, 12 };
            int[] Array2 = { 1, 3, 7, 10 };
            var c4 = new Class4();
            c4.ArrayNew(Array1, Array2);


            //int inputNumber = Convert.ToInt32(inputNumber);
            //c2 = Convert.ToString(Console.ReadLine());
            //Console.WriteLine(Class2.GetSum(c2));
            //string format2 = $"the sum of {i3} and {i4} is {i4 + i3}";

            //string myString = Convert.ToString(n);


            //string number = Console.ReadLine();
            //var c2 = new Class2();
            //Console.WriteLine();


            //int inputNumber = 1;
            //Console.WriteLine("3.");
            //Console.WriteLine("Enter any number: ");
            // inputNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Product of digits = " + Class3.GetProduct(inputNumber);

            //4.







            Console.ReadLine();
        }

    }
}