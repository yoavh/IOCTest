using System.IO;

namespace Builders
{
    public class ClassWriter
    {
        public void Write(string path, string content)
        {
            using (var classFile = System.IO.File.Create(path))
            using (var writer = new StreamWriter(classFile))
            {
                writer.WriteLine(content);
            }
        }
    }
}