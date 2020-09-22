// In this section you add the namespaces that you'll be using in your code
// using namespace

using System;
using System.Collections.Generic;
//using System.Math; <-- this is an error, it doesn't exist
using System.IO;    // <- since we don't use this namespace in the code, it can be removed from the list
using Microsoft.CSharp; // same for this one

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello how are you?");

            // List<T> requires System.Collections.Generic namespace
            // A List is similar to an array, can contain several items
            // Difference: A List doesn't specify size, it can grow as needed

            List<int> numbers = new List<int>();
            numbers.Add(6);
            numbers.Add(8);
            numbers.Add(-90);

            Console.WriteLine("Type a key to exit...");
            Console.ReadKey();

        }
    }
}
