﻿/*A marketing company wants to keep record of its employees. 
Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee 
using appropriate primitive data types. Use descriptive names. Print the data at the console.*/
using System;

class EmployeeData
    {
        static void Main()
        {
           
            string firstName = "Georgi";
            string lastName = "Vasilev";
            int age = 35;
            char gender = 'm';
            long personalId = 8306112507;
            long uniqueEmployeeNumber = 2756000078527569999;

            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.WriteLine("Age: {0}", age);

            if (gender == 'm')
            {
                Console.WriteLine("Gender: male");
            }
            else
            {
                Console.WriteLine("Gender: female");
            }
           
            Console.WriteLine("Personal ID number: {0}", personalId);
            Console.WriteLine("Unique employee number: {0}", uniqueEmployeeNumber);
        }
    }

