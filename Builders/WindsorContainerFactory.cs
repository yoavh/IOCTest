using System;
using System.Collections.Generic;
using System.Text;

namespace Builders
{
    public class WindsorContainerFactory
    {
        public string Build(string containerName, IDictionary<string, string> inplementations)
        {
            var _createContainer = CreateContainer(containerName);

            var _createRegister = new StringBuilder();
            var _createResolve = new StringBuilder();
            foreach (var inplementation in inplementations)
            {
                // _createRegister.AppendLine(CreateRegister(containerName, inplementation.Key, inplementation.Value));
                _createResolve.AppendLine(CreateResolve(containerName, inplementation.Key, inplementation.Value));
            }

            _createRegister.AppendLine($"{containerName}.Register(AllTypes.FromAssembly(Assembly.GetExecutingAssembly()))");
            var body = new StringBuilder();
            body.AppendLine(CreateContainer(containerName));
            body.AppendLine(_createRegister.ToString());
            body.AppendLine(_createResolve.ToString());
            return body.ToString();
            // return $"public void TestWindsorContainer(){{{Environment.NewLine}{body}{Environment.NewLine}}}";
        }
        private string CreateContainer(string containerName)
        {
            return $"var {containerName} = new WindsorContainer()";
        }
        private string CreateRegister(string containerName, string interfaceName, string className)
        {
            return $"{containerName}.Register(Component.For<{interfaceName}>().ImplementedBy<{className}>());";
        }
        private string CreateResolve(string containerName, string interfaceName, string varName = null)
        {
            var name = string.IsNullOrWhiteSpace(varName) ? $"{interfaceName.Substring(1, 2).ToLower()}{interfaceName.Substring(2)}" : varName;
            return $"var {name} = {containerName}.Resolve<{interfaceName}>();";
        }
    }

}