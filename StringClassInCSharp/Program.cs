﻿using System;

namespace StringClassInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //using regular strings
            string columns = "Column 1\tColumn 2\tColumn 3";
            Console.WriteLine(columns);
            Console.WriteLine();

            //using the verbatim strings
            string title = @"My pensive SARA! thy soft cheek reclined
                  Thus on mine arm,most soothing sweet it is
                  To sit beside our Cot,...";

            Console.WriteLine(title);
        }
    }
}
