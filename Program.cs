﻿using System;
using System.Data.Entity;

namespace StaffOperatorsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                var student = new Student { Name = "John Doe" };
                context.Students.Add(student);
                context.SaveChanges();
                Console.WriteLine("Student added successfully!");
            }
            Console.ReadLine();
        }
    }
}