using System;
using System.Collections.Generic;
using System.Linq;

namespace Builders
{
    public class ClassBuilder
    {
        public string Build(string namespaceName, string className, IDictionary<string, string> constractorParams = null)
        {
            var interfaceSection = CreateInterfaceSection($"I{className}");
            var classSection = CreateClassSection(className, constractorParams);
            var namesapceSection = CreateNamespaceSection(namespaceName, interfaceSection, classSection);
            return namesapceSection;
        }
        private string CreateNamespaceSection(string namespaceName, string interfaceSection, string classSection)
        {
            return $"namespace {namespaceName}{{{interfaceSection}{classSection}}}";
        }

        private string CreateInterfaceSection(string interfaceName)
        {
            return $"public interface {interfaceName}{{}}";
        }
        private string CreateClassSection(string className, IDictionary<string, string> constractorParams)
        {
            var constructorSection = CreateConstructorSection(className, constractorParams);
            return $"public class {className}: I{className}{{{constructorSection}}}";
        }
        private string CreateConstructorSection(string className, IDictionary<string, string> constractorParams)
        {
            var constractorParamsString = constractorParams == null ? string.Empty : string.Join(",", constractorParams.Select(x => $"{x.Key} {x.Value.Substring(0, 1).ToLower()}{x.Value.Substring(1)}"));
            return $"public {className}({constractorParamsString}){{}}";
        }
    }
}
