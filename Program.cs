//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// string revrse

using System;

class Program
{
    static void Main()
    {
        

        Console.WriteLine("enter a string");
        string inout = Console.ReadLine();

        string rev = "";
        for (int i = inout.Length-1; i >= 0; i--) { 
            rev += inout[i];
        }

        Console.WriteLine(rev);
    }
}
