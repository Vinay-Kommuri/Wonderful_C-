using System;
using System.Collections.Generic;

namespace Example
{
    class Program
    {
        static void Main(string[] args)

        {  
            Book book=new Book(10);
            book.AddGrade(10.2);
            book.AddGrade(30.2);
            book.AddGrade(20.2);
          
          var x=book.GetStatistics();
            
           Console.WriteLine(x.Avg);
           Console.WriteLine($"minimum value is {x.low}");
           Console.WriteLine($"maximum value is {x.high}");


           
        }

    }
}
