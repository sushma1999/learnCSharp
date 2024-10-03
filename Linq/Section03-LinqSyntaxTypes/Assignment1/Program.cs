using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1:
            // Write a simple C# program to declare a list of integer numbers, 
            // followed by writing queries using both query and method syntax 
            // to calculate their square (num * num), and finally print them to the console.

            // Step 1: Getting data source


            // Query syntax
            // Step 2: Writing query 
            // Step 3: Executing query 


            // Method syntax
            // Step 2: Writing query 
            // Step 3: Executing query 

            List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10};

            //Query Syntax
            IEnumerable<int> querySquare = from no in numbers
                                            select no * no;
            System.Console.WriteLine("Query Syntax output :");
            foreach( int n in querySquare)
            System.Console.WriteLine(n);

            //Method Syntax
            IEnumerable<int> MethodSquare = numbers.Select(i=>i*i);
            System.Console.WriteLine("Method Syntax output:");
            foreach (int a in MethodSquare)
            System.Console.WriteLine(a);
                 
        }
    }
}
