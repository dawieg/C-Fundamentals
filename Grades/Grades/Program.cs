﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

           
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("Avarage GradeBook" + " :" + stats.AverageGrade);
            Console.WriteLine("Highest GradeBook" + " :" + stats.HighestGrade);
            Console.WriteLine("Lowest GradeBook" + " :" + stats.LowestGrade);
            
        }
    }
}
