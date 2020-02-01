using System;
using Xunit;
using Builders;
using System.IO;
using System.Collections.Generic;

namespace BuildersTests
{
    public class ClassBuilderTest
    {
                [Fact]
                public void CreateClass()
                {
                    var classesToCreate = new List<string>{
                        "Yoav1","Yoav2"
                    };
                    var folderPath = "/Users/yoavhagashi/IOCTest/WindsorIoc";
                    var builder = new ClassBuilder();
                    var writer = new ClassWriter();
                    var windsorContainerFactory = new WindsorContainerFactory();
                    var constractorParams = new Dictionary<string, string>();
                    foreach (var className in classesToCreate)
                    {
                        var newClass = builder.Build("WindsorIoc", className, constractorParams);
                        var path = Path.Join(folderPath, $"{className}.cs");
                        writer.Write(path, newClass);
                        constractorParams.Add($"I{className}", className);
                    }
                    var containerTestMethod = windsorContainerFactory.Build("container", constractorParams);
                    var windsorContainerTestnewClass = builder.Build("WindsorIoc", "WindsorContainer", null, new Dictionary<string, string> { { "TestContainer", containerTestMethod } });
                    var pathWindsorContainerTest = Path.Join(folderPath, $"WindsorContainerTest.cs");
                    writer.Write(pathWindsorContainerTest, windsorContainerTestnewClass);
                }

        [Fact]
        public void CreateWindsorContainerBuilder()
        {
            var apperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var firstInt = 1;
            var secondInt = 1;
            var classesToCreate = new List<string>();
            for (var i = 0; i < apperCase.Length; i++)
            {
                for (var j = 0; j < firstInt; j++)
                {
                    for (var k = 0; k < secondInt; k++)
                    {
                        var className = $"{apperCase[i]}{j}{k}";
                        classesToCreate.Add(className);
                    }
                }
            }
            var nameSpace = "WindsorIoc";
            var folderPath = $"/Users/yoavhagashi/IOCTest/{nameSpace}";
            var builder = new ClassBuilder();
            var writer = new ClassWriter();
            var windsorContainerBuilder = new WindsorContainerBuilder();
            var constractorParams = new Dictionary<string, string>();
            foreach (var className in classesToCreate)
            {
                var newClass = builder.Build("WindsorTest", className, constractorParams);
                var path = Path.Join(folderPath, "Classes", $"{className}.cs");
                writer.Write(path, newClass);
                constractorParams.Add($"I{className}", className);
                windsorContainerBuilder.AddRegisteration($"I{className}", className);
                windsorContainerBuilder.AddResolve($"I{className}");

                if (constractorParams.Count >= 10)
                {
                    constractorParams.Clear();
                }
            }
            windsorContainerBuilder.WithTimer();
            var containerTestMethod = windsorContainerBuilder.Build();
            var windsorContainerTestnewClass = builder.Build(nameSpace, "WindsorContainerTest", null, new Dictionary<string, string> { { "TestContainer", containerTestMethod } }, windsorContainerBuilder.GetUsingSection());
            var pathWindsorContainerTest = Path.Join(folderPath, $"WindsorContainerTest.cs");
            writer.Write(pathWindsorContainerTest, windsorContainerTestnewClass);
        }
    }
}
