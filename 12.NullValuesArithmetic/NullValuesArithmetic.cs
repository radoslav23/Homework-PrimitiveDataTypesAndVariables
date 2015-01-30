/*Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.*/
using System;

class NullValuesArithmetic
    {
        static void Main()
        {

            int? nulInteger = null;
            double? nullDouble = null;
            Console.WriteLine("Nullable integer: {0}", nulInteger);
            Console.WriteLine("Nullable double: {0}", nullDouble);
            nulInteger = 15;
            nullDouble = 7.5;
            Console.WriteLine("New integer: {0}", nulInteger);
            Console.WriteLine("New double: {0}", nullDouble);   
        }
    }

