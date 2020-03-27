using System;
using System.Collections.Generic;

namespace Example
{
    class Book
    {
        
        public Book(int x)
        {
            grade=new List<double>();
            this.x=x;
        }
        public void AddGrade(double g1)      
        {
            grade.Add(g1);
        }
        public Statistics GetStatistics()
        {
         
         var statistics = new Statistics();
          int NumberOfSubj=grade.Count;
           var result=0.0;
           statistics.high=double.MinValue;
           statistics.low=double.MaxValue;
           foreach (var item in grade)
            {
                result= result+item;
                statistics.high=Math.Max(item,statistics.high);
                statistics.low=Math.Min(item,statistics.low);
            }

           statistics.Avg=result/NumberOfSubj;
           
           return statistics;
        }

        public int x;
        List<double> grade; 
    }

}