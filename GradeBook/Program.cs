﻿using System;
using GradeBook.UserInterfaces;
using GradeBook.GradeBooks;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("#=======================#");
            Console.WriteLine("# Welcome to GradeBook! #");
            Console.WriteLine("#=======================#");
            Console.WriteLine();

            StartingUserInterface.CommandLoop();
            
            Console.WriteLine("Thank you for using GradeBook!");
            Console.WriteLine("Have a nice day!");
            Console.Read();
        }
    }
}