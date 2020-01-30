using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Builders
{
    public class ClassWriter
    {
        public void Write(string path, string content)
        {
            var classFile = System.IO.File.Create(path);
            using (var writer = new StreamWriter(classFile))
            {
                writer.WriteLine(content);
            }
        }
    }
}