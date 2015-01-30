/*Find online more information about ASCII (American Standard Code 
for Information Interchange) and write a program that prints the 
entire ASCII table of characters on the console (characters from 0 to 255).
Note: Some characters have a special purpose and will not be 
displayed as expected. You may skip them or display them differently.*/
using System;

class PrintTheAsciiTable
    {
        static void Main()
        {
            for (int i = 0; i < 256; i++)
            {                
                Console.WriteLine((char)i);
            }
        }
    }

