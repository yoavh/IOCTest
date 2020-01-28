using System;
using System.Collections.Generic;
using System.Linq;

namespace Builders
{
    public class ClassBuilder
    {
        private string _namesapceSection;
        private string _classSection;
        private string _constractorSection;
        public string Build(string namespaceName, string className, IDictionary<string, string> constractorParams=null)
        {
            InitClassSection(className,constractorParams);
            InitNamespaceSection(namespaceName);
            return _namesapceSection;
        }
        private void InitNamespaceSection(string namespaceName)
        {
            _namesapceSection = $"namespace {namespaceName}{{{_classSection}}}";
        }
        private void InitClassSection(string className, IDictionary<string, string> constractorParams)
        {
            InitConstructorSectio(className, constractorParams);
            _classSection = $"public class {className}: I{className}{{{_constractorSection}}}";
        }
        private void InitConstructorSectio(string className, IDictionary<string, string> constractorParams)
        {
            var constractorParamsString = string.Join(",", constractorParams?.Select(x => $"{x.Key} {x.Value}"));
            _constractorSection = $"public {className}({constractorParamsString})";
        }


    }
}
