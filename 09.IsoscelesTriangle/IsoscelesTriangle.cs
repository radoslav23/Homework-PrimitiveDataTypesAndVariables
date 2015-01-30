/*Write a program that prints an isosceles triangle 
of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © ©
Note: The © symbol may be displayed incorrectly at the console 
so you may need to change the console character encoding to 
UTF-8 and assign a Unicode-friendly font in the console.
Note: Under old versions of Windows the © symbol may still be displayed incorrectly, 
regardless of how much effort you put to fix it.*/
using System;

class IsoscelesTriangle
    {
        static void Main()
        {
            char symbol = '\u0040';           
            string space = " ";

            Console.WriteLine(space + space + space + symbol);
            Console.WriteLine(space + space + symbol + space + symbol);
            Console.WriteLine(space + symbol + space + space + space + symbol);
            Console.WriteLine(symbol + space + symbol + space + symbol + space + symbol);

            //second solution

            Console.WriteLine();
            Console.WriteLine(@"
                    @
                   @ @
                  @   @
                 @ @ @ @
                ");
                
        }
    }

