using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builders
{
    public class ClassBuilder
    {
        public string Build(string namespaceName, string className, IDictionary<string, string> constractorParams = null, IDictionary<string, string> methods = null, string usings = null)
        {
            var interfaceSection = CreateInterfaceSection($"I{className}");
            
            var classSection = CreateClassSection(className, constractorParams,methods);
            var namesapceSection = CreateNamespaceSection(namespaceName, interfaceSection, classSection);

            return usings == null ? namesapceSection : $"{usings}{Environment.NewLine}{namesapceSection}";
        }
        private string CreateNamespaceSection(string namespaceName, string interfaceSection, string classSection)
        {
            var namespaceSection = new StringBuilder();
            namespaceSection.AppendLine($"namespace {namespaceName}{{");
            namespaceSection.AppendLine(interfaceSection);
            namespaceSection.AppendLine(classSection);
            namespaceSection.AppendLine($"}}");
            return namespaceSection.ToString();
        }

        private string CreateInterfaceSection(string interfaceName)
        {
            return $"public interface {interfaceName}{{}}";
        }
        private string CreateClassSection(string className, IDictionary<string, string> constractorParams,IDictionary<string, string> methods)
        {
            var methodsSections = CreateMethodsSection(methods);
            var constructorSection = CreateConstructorSection(className, constractorParams);
            return $"public class {className}: I{className}{{{constructorSection}{methodsSections}}}";
        }
        private string CreateConstructorSection(string className, IDictionary<string, string> constractorParams)
        {
            var constractorParamsString = constractorParams == null ? string.Empty : string.Join(",", constractorParams.Select(x => $"{x.Key} {x.Value.Substring(0, 1).ToLower()}{x.Value.Substring(1)}"));
            return $"public {className}({constractorParamsString}){{}}";
        }
        private string CreateMethodsSection(IDictionary<string, string> methods = null)
        {
            if (methods == null)
            {
                return string.Empty;
            }
            var methodsSections = new StringBuilder();
            foreach (var method in methods)
            {
                methodsSections.AppendLine(CreateMethodSection(method.Key, method.Value));
            }
            return methodsSections.ToString();
        }
        private string CreateMethodSection(string methodName, string body)
        {
            return $"public void {methodName}(){{{Environment.NewLine}{body}{Environment.NewLine}}}";
        }
    }
}
