using System;
using System.Linq;
using System.Collections.Generic;


namespace WindsorIoc
{
    class Program
    {
        static void Main(string[] args)
        {
            // var  tester = new WindsorContainerTest();
            var count = 1000;
            var resolve = new WindsorContainerTestResolve();
            var injection = new WindsorContainerTestInjection();
            var resolveResults = new List<TimeSpan>();
            var injectionResults = new List<TimeSpan>();
            for (var i = 0; i < count; i++)
            {
                resolveResults.Add(resolve.TestContainer());
                injectionResults.Add(injection.TestContainer());
            }
            Console.WriteLine("========================");
            Console.WriteLine($"first resolve:\t\t {resolveResults.OrderBy(x=>x).First()}");
            Console.WriteLine($"first injection:\t {injectionResults.OrderBy(x=>x).First()}");
            Console.WriteLine($"last resolve:\t\t {resolveResults.OrderBy(x=>x).Last()}");
            Console.WriteLine($"last injection:\t\t {injectionResults.OrderBy(x=>x).Last()}");
            var a =resolveResults[0];
            var b =injectionResults[0];
            for(var j=1;j<count;j++)
            {
                a.Add(resolveResults[j]);
                b.Add(injectionResults[j]);
            }

            Console.WriteLine($"Total resolve:\t\t {a}");
            Console.WriteLine($"Total injection:\t {b}");
            Console.WriteLine($"mean resolve:\t\t {a.Divide(count)}");
            Console.WriteLine($"mean injection:\t\t {b.Divide(count)}");
        }
    }
}
