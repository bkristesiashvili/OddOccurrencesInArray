using System;

namespace OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sln = new Solution();
            var array = new int[] { 8, 3, 8, 3, 8, 8, 9 };

            Console.WriteLine($" Odd Occurred In Array: { sln.solution(array) }");

            Console.ReadLine();
        }
    }
}
