using System;
using System.Collections.Generic;
using System.Text;


namespace Builders
{
    public class WindsorContainerBuilder
    {
        private bool withTimer;
        private string _startTimer;
        private string _stopTimer;
        private StringBuilder _using;
        private StringBuilder _registerationSection;
        private StringBuilder _resolverSection;
        private const string _containerName = "container";
        public WindsorContainerBuilder()
        {
            withTimer = false;
            _using = new StringBuilder();
            _registerationSection = new StringBuilder();
            _resolverSection = new StringBuilder();
            this.WithUsing(new[] { "Castle.Windsor", "Castle.MicroKernel.Registration" });
        }

        public string GetUsingSection()
        {
            return _using.ToString();
        }
        public string Build()
        {
            var build = new StringBuilder();
            build.AppendLine($"var {_containerName} = new WindsorContainer();");
            if (_registerationSection.Length > 0)
            {
                build.AppendLine(_registerationSection.ToString());
            }
            if (withTimer)
            {
                build.AppendLine(_startTimer);
            }
            if (_resolverSection.Length > 0)
            {
                build.AppendLine(_resolverSection.ToString());
            }
            if (withTimer)
            {
                build.AppendLine(_stopTimer);
            }
            build.AppendLine($"return {_containerName};");
            return build.ToString();
        }
        public WindsorContainerBuilder AddRegisteration(string interfaceName, string className)
        {
            _registerationSection.AppendLine(CreateRegister(interfaceName, className));
            return this;
        }
        public WindsorContainerBuilder AddResolve(string interfaceName, string varName = null)
        {
            _resolverSection.AppendLine(CreateResolve(interfaceName, varName));
            return this;
        }
        public WindsorContainerBuilder WithTimer()
        {
            if (withTimer)
            {
                return this;
            }
            withTimer = true;
            _startTimer = CreateStartTimer();
            _stopTimer = CreateStopTimer();
            this.WithUsing(new[] { "System", "System.Diagnostics" });
            return this;
        }

        public WindsorContainerBuilder WithUsing(IEnumerable<string> useses)
        {
            foreach (var item in useses)
            {
                _using.AppendLine($"using {item};");
            }
            return this;
        }
        private string CreateRegister(string interfaceName, string className)
        {
            return $"{_containerName}.Register(Component.For<{interfaceName}>().ImplementedBy<{className}>());";
        }
        private string CreateResolve(string interfaceName, string varName = null)
        {
            return varName == null ? $"{_containerName}.Resolve<{interfaceName}>();" : $"var {varName} = {_containerName}.Resolve<{interfaceName}>();";
        }
        private string CreateStartTimer()
        {
            return $"var stopWatch = new Stopwatch();{Environment.NewLine}stopWatch.Start();";
        }
        private string CreateStopTimer()
        {
            return $"stopWatch.Stop();{Environment.NewLine}var ts = stopWatch.Elapsed;{Environment.NewLine}Console.WriteLine($\"Time Elapsed: {{ts}}\");";
        }
    }
}
