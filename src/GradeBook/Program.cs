using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Program
    {
        static void Main(string[] args)
        {              
            var book = new Book("Bryan's Gradebook");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            
                       
            var stats= book.GetStatistics();

            Console.WriteLine($"The lowest grade is {Math.Round(stats.High, 2)}");
            Console.WriteLine($"The highest grade is {Math.Round(stats.Low, 2)}");
            Console.WriteLine($"The average grade is {Math.Round(stats.Average, 2)}");
           
        }

    }
}
