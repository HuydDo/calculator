using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book
  { 
    public Book(string name)
    {
      grades = new List<double>();
      Name = name;
    }
    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public Statistics GetStatistics()
    {
      var result = new Statistics();
      result.Average  = 0.0;
      result.High = double.MinValue;
      result.Low = double.MaxValue;

      foreach(double grade in grades){
        result.High = Math.Max(grade, result.High);
        result.Low = Math.Min(grade, result.Low);
        result.Average += grade;
      }
      result.Average /= grades.Count;
      
      return result;
    }
    /* Console.WriteLine($"The average grade is {result:N1}");
      Console.WriteLine($"The highest grade is {highGrade:N1}");
      Console.WriteLine($"The average grade is {lowGrade:N1}"); */
    private List<double> grades;
    public string Name;

   
  }

}
    


