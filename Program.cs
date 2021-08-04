using System;

namespace Console1
{
    class Program
    {
         

        static void Main(string[] args)
        {

        // Task 1 //
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine ("Task 1");
            Console.WriteLine(" ");
            double a = 16.80;
            double b = 12.40;
            double geo_mean = Math.Sqrt (a*b);
            Console.WriteLine ($"Geometric mean = {Math.Round(geo_mean, 2)}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

        //Task 2 //
      
            Console.WriteLine("Task 2");
            Console.WriteLine(" ");
            double aa = 1.40;
            double bb = -5.50;
            double cc = 0.60;
            double bbcc = cc + Math.Abs(bb);
            double aacc = aa-cc;
            double result = bbcc + aacc;
            Console.WriteLine($"Result = {Math.Round(result, 1)}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

        //Task 3 //

            Console.WriteLine("Task 3");
            Console.WriteLine(" ");
            double x1 = -6.20;
            double y1 = 5.20;
            double x2 = 2.10;
            double y2 = 9.80;
            double distance = Math.Sqrt(Math.Pow(x2-x1, 2)+ Math.Pow(y2-y1,2));
            Console.WriteLine($"distance = {Math.Round(distance, 2)}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

        //Task 4 //

            Console.WriteLine("Task 4");
            Console.WriteLine(" ");
            double num = 41;
            double num1 = num%10;
            double num2 = Math.Round (num/10, 0);
            Console.WriteLine(num1); Console.WriteLine(num2);
            Console.WriteLine("Could not place digits in one line");
            Console.WriteLine(" ");

        //Task 5 //

            Console.WriteLine("Task 5");
            Console.WriteLine(" ");
            double n = 10985;
            double result1 = Math.Round(n/60, 0);
            Console.WriteLine($"Result =  {result1}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

       //Task 6 //

            Console.WriteLine("Task 6");
            Console.WriteLine(" ");
            double k = 202;
            double day = num%7;
            Console.WriteLine ($"Weekday number = {day}");
            Console.WriteLine(" ");
            Console.WriteLine(" "); 
            Console.WriteLine(" ");
        }

    }
}
