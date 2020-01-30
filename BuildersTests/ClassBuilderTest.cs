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
            var folderPath = "/Users/yoavhagashi/Documents/IOCTest/WindsorIoc";
            var builder = new ClassBuilder();
            var writer = new ClassWriter();
            var constractorParams = new Dictionary<string,string>();
            foreach (var className in classesToCreate)
            {
                var newClass = builder.Build("WindsorIoc", className, constractorParams);
                var path = Path.Join(folderPath, $"{className}.cs");
                writer.Write(path, newClass);
                constractorParams.Add($"I{className}",className);
            }
        }
    }
}
