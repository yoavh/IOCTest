using System;
using Xunit;
using Builders;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace BuildersTests
{
    public class ClassBuilderTest
    {
        int maxConstructor = 50;
        int firstInt = 10;
        int secondInt = 15;
        [Fact]
        public void CreateClass()
        {
            var classesToCreate = new List<string>{
                        "Yoav1","Yoav2"
                    };
            var folderPath = "/Users/yoavhagashi/Project/IOCTest/WindsorIoc";
            var builder = new ClassBuilder();
            var writer = new ClassWriter();
            var windsorContainerFactory = new WindsorContainerFactory();
            var constractorParams = new Dictionary<string, string>();
            foreach (var className in classesToCreate)
            {
                var newClass = builder.Build("WindsorIoc", className,true, constractorParams);
                var path = Path.Join(folderPath, $"{className}.cs");
                writer.Write(path, newClass);
                constractorParams.Add($"I{className}", className);
            }
            var containerTestMethod = windsorContainerFactory.Build("container", constractorParams);
            var windsorContainerTestnewClass = builder.Build("WindsorIoc", "WindsorContainer", true, null, new Dictionary<string, string> { { "TestContainer", containerTestMethod } });
            var pathWindsorContainerTest = Path.Join(folderPath, $"WindsorContainerTest.cs");
            writer.Write(pathWindsorContainerTest, windsorContainerTestnewClass);
        }

        [Fact]
        public void CreateWindsorContainerBuilderInjection()
        {
            var apperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var classesToCreate = new List<string>();
            for (var i = 0; i < apperCase.Length; i++)
            {
                for (var j = 0; j < firstInt; j++)
                {
                    for (var k = 0; k < secondInt; k++)
                    {
                        var className = $"{apperCase[i]}{j}{k}";
                        classesToCreate.Add($"{className}Inject");
                    }
                }
            }
            var nameSpace = "WindsorIoc";
            var folderPath = $"/Users/yoavhagashi/Project/IOCTest/{nameSpace}";
            var builder = new ClassBuilder();
            var writer = new ClassWriter();
            var windsorContainerBuilder = new WindsorContainerBuilder();
            var constractorParams = new Dictionary<string, string>();
            foreach (var className in classesToCreate)
            {
                var newClass = builder.Build("WindsorIoc", className, true, constractorParams);
                var path = Path.Join(folderPath, "Classes", $"{className}.cs");
                writer.Write(path, newClass);
                constractorParams.Add($"I{className}", className);
                windsorContainerBuilder.AddRegisteration($"I{className}", className);
                // windsorContainerBuilder.AddResolve($"I{className}");

                if (constractorParams.Count >= maxConstructor)
                {
                    constractorParams.Clear();
                }
            }
            // windsorContainerBuilder.WithTimer();
            var containerTestMethod = windsorContainerBuilder.Build();
            var windsorContainerTestnewClass = builder.Build(nameSpace, "WindsorContainerTestInjection",true, null, new Dictionary<string, string> { { "TestContainer", containerTestMethod } }, windsorContainerBuilder.GetUsingSection());
            var pathWindsorContainerTest = Path.Join(folderPath, $"WindsorContainerTestInjection.cs");
            writer.Write(pathWindsorContainerTest, windsorContainerTestnewClass);
        }

        [Fact]
        public void CreateWindsorContainerBuilderResolver()
        {
            var apperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var classesToCreate = new List<string>();
            for (var i = 0; i < apperCase.Length; i++)
            {
                for (var j = 0; j < firstInt; j++)
                {
                    for (var k = 0; k < secondInt; k++)
                    {
                        var className = $"{apperCase[i]}{j}{k}";
                        classesToCreate.Add($"{className}Resolve");
                    }
                }
            }
            var nameSpace = "WindsorIoc";
            var folderPath = $"/Users/yoavhagashi/Project/IOCTest/{nameSpace}";
            var builder = new ClassBuilder();
            var writer = new ClassWriter();
            var windsorContainerBuilder = new WindsorContainerBuilder();
            var constractorParams = new Dictionary<string, string>();
             var usingInClass = new StringBuilder();
             usingInClass.AppendLine("using Castle.Windsor;");
            usingInClass.AppendLine("using Castle.MicroKernel.Registration;");
            foreach (var className in classesToCreate)
            {
                var newClass = builder.Build("WindsorIoc", className, false, constractorParams, null, usingInClass.ToString());
                var path = Path.Join(folderPath, "Classes", $"{className}.cs");
                writer.Write(path, newClass);
                constractorParams.Add($"I{className}", className);
                windsorContainerBuilder.AddRegisteration($"I{className}", className);
                // windsorContainerBuilder.AddResolve($"I{className}");

                if (constractorParams.Count >= maxConstructor)
                {
                    constractorParams.Clear();
                }
            }
            // windsorContainerBuilder.WithTimer();
            var containerTestMethod = windsorContainerBuilder.Build();
            var windsorContainerTestnewClass = builder.Build(nameSpace, "WindsorContainerTestResolve",true, null, new Dictionary<string, string> { { "TestContainer", containerTestMethod } }, windsorContainerBuilder.GetUsingSection());
            var pathWindsorContainerTest = Path.Join(folderPath, $"WindsorContainerTestResolve.cs");
            writer.Write(pathWindsorContainerTest, windsorContainerTestnewClass);
        }
    }
}
