using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculateAnAverageGrade()
        {
          //arrange
          var book = new Book("");
          book.AddGrade(89.1);
          book.AddGrade(90.5);
          book.AddGrade(77.3);

          //act
          var result = book.GetStatistics();
          
          //assert
          Assert.Equal(85.6, result.Average, 1);
          Assert.Equal(90.5, result.High, 1);
          Assert.Equal(77.3, result.Low , 1);
        }
    }
}
//dotnet new xunit
//dotnet add package package xunit --version 2.4.1
//dotnet add reference ../../src/GradeBook/GradeBook.csproj
//dotnet test