using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using Castle.Windsor;
using Castle.MicroKernel.Registration;


namespace WindsorIoc
{
    class Program
    {
        static IList<Type> GetInterfaces(string substring)
        {
            var types = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(p => p.IsInterface && p.Name.Contains(substring))
            .ToList();

            return types;
        }
        static WindsorContainer InitResolve()
        {
            var resolvetion = new WindsorContainerTestResolve();
            var resolvetionContainer = resolvetion.TestContainer();
            resolvetionContainer.Register(Component.For<IMyContainer>().ImplementedBy<MyContainer>().LifestyleSingleton());
            var mycontainer = resolvetionContainer.Resolve<IMyContainer>();
            mycontainer.Init(resolvetionContainer);
            return resolvetionContainer;
        }
        static IList<TimeSpan> RunResolve(WindsorContainer resolvetionContainer)
        {
            Random rnd = new Random();

            var interfaces = GetInterfaces("Resolve");
            var count = 1000 * interfaces.Count;
            var indeications = new bool[interfaces.Count];
            var resolvetionTimeSpan = new List<TimeSpan>();
            for (var i = 0; i < count; i++)
            {
                int r = rnd.Next(interfaces.Count);
                var item = interfaces[r];
                indeications[r] = true;
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                resolvetionContainer.Resolve(item);
                stopWatch.Stop();
                resolvetionTimeSpan.Add(stopWatch.Elapsed);
            }
            return resolvetionTimeSpan;
        }

        static WindsorContainer InitInjection()
        {
            var injection = new WindsorContainerTestInjection();
            return injection.TestContainer();
        }
        static IList<TimeSpan> RunInjection(WindsorContainer injectionContainer)
        {
            Random rnd = new Random();
            var interfaces = GetInterfaces("Inject");
            var count = 1000 * interfaces.Count;
            var indeications = new bool[interfaces.Count];
            var injectionTimeSpan = new List<TimeSpan>();
            for (var i = 0; i < count; i++)
            {
                int r = rnd.Next(interfaces.Count);
                var item = interfaces[r];
                indeications[r] = true;
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                injectionContainer.Resolve(item);
                stopWatch.Stop();
                injectionTimeSpan.Add(stopWatch.Elapsed);
            }
            return injectionTimeSpan;
        }
        static void Main(string[] args)
        {
            var resolvetionTimeSpan = new List<TimeSpan>();
            var injectionTimeSpan = new List<TimeSpan>();
            var injection = InitInjection();
            var resolve = InitResolve();
            for (var i = 0; i < 20; i++)
            {
                Console.WriteLine($"======================={i}=======================");
                injectionTimeSpan.AddRange(RunInjection(injection));
                resolvetionTimeSpan.AddRange(RunResolve(resolve));

            }
            Console.WriteLine($"\t\tinjection\t\tresolvetion");
            Console.WriteLine($"total:\t\t{injectionTimeSpan.Count}\t\t{resolvetionTimeSpan.Count}");
            Console.WriteLine($"Min:\t\t{injectionTimeSpan.OrderBy(x => x).First()}\t{resolvetionTimeSpan.OrderBy(x => x).First()}");
            Console.WriteLine($"Max:\t\t{injectionTimeSpan.OrderBy(x => x).Last()}\t{resolvetionTimeSpan.OrderBy(x => x).Last()}");
            Console.WriteLine($"Average:\t{TimeSpan.FromTicks(Convert.ToInt64(injectionTimeSpan.Select(t => t.Ticks).Average()))}\t{TimeSpan.FromTicks(Convert.ToInt64(resolvetionTimeSpan.Select(t => t.Ticks).Average()))}");
            Console.WriteLine($"Sum:\t\t{new TimeSpan(injectionTimeSpan.Sum(x => x.Ticks))}\t{new TimeSpan(resolvetionTimeSpan.Sum(x => x.Ticks))}");
        }
    }
}
