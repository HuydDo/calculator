﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] numbers=  new []{12.7, 10.3, 6.11};
            
            List<double> grades = new List<double>(){12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);
            

            var result = 0.0;
            foreach(double number in grades){
              result +=number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N2}");

            if(args.Length > 0)
            {
              Console.WriteLine($"Hello, {args[0]} !");
            }
            else 
            {
              Console.WriteLine("Hello!"); 
            }
        }
    }
}

//dotnet run -- Huy
//cw cwl tab tab
//ctrl .
// from gradebook folder you can use dotnet run --project src\GradeBook