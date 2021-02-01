using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // double [] numbers=  new []{12.7, 10.3, 6.11};
            var book = new Book("Scott's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var stats = book.GetStatistics();
           
           Console.WriteLine($"The lowest grade is {stats.Low}");
           Console.WriteLine($"The highest grade is {stats.High}");
           Console.WriteLine($"The average grade is {stats.Average:N1}");
           /*  var grades = new List<double>(){12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);
          
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(double number in grades){
             
              highGrade = Math.Max(number, highGrade);
              lowGrade = Math.Min(number, lowGrade);
              result +=number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
            Console.WriteLine($"The highest grade is {highGrade:N1}");
            Console.WriteLine($"The average grade is {lowGrade:N1}"); */

           /*  if(args.Length > 0)
            {
              Console.WriteLine($"Hello, {args[0]} !");
            }
            else 
            {
              Console.WriteLine("Hello!"); 
            } */
        }
    }
}

//dotnet run -- Huy
//cw cwl tab tab
//ctrl .
// from gradebook folder you can use dotnet run --project src\GradeBook