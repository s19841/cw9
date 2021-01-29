using System;
using System.Linq;
namespace LinqConsoleApp
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Emps:");
            LinqSamples.Emps.ToList().ForEach(Console.WriteLine);
            Console.WriteLine("\nDepts:");
            Console.WriteLine();
            Console.WriteLine("Depts:");
            LinqSamples.Depts.ToList().ForEach(Console.WriteLine);
            LinqSamples.Przyklad1();
            LinqSamples.Przyklad2();
            LinqSamples.Przyklad3();
            LinqSamples.Przyklad4();
            LinqSamples.Przyklad5();
            LinqSamples.Przyklad6();
            LinqSamples.Przyklad7();
            LinqSamples.Przyklad8();
            LinqSamples.Przyklad9();
            LinqSamples.Przyklad10();
            LinqSamples.Przyklad11();
            LinqSamples.Przyklad12();
        }
    }
}