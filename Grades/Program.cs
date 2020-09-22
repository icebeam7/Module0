using System;
using System.Linq;
/* The System.Linq namespace provides classes and interfaces that support queries
 * that use Language-Integrated Query (LINQ).
 * Some available functions are Min, Max, Average, Sum...
 * it mainly works with collections and arrays
*/

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades;
            int size, sum = 0, average;

            Console.WriteLine("How many students are in the group?");
            size = int.Parse(Console.ReadLine());

            grades = new int[size];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Type the grade of the student " + (i + 1));
                grades[i] = int.Parse(Console.ReadLine());
            }

            foreach (int g in grades)
            {
                sum += g;
                //sum = sum + g; <- another way to do it
            }

            // if you want to use a for loop instead of foreach...
            /*
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            */

            average = sum / size;
            Console.WriteLine("The average is " + average);

            // Another way to calculate the average without loop, using Linq extension:
            double avg = grades.Average();
            Console.WriteLine("The average is " + avg);

            // You can directly get the minimum and maximum values from a collection / array
            int min = grades.Min();
            int max = grades.Max();
            Console.WriteLine("The lowest grade is " + min);
            Console.WriteLine("The highest grade is " + max);
        }
    }
}
