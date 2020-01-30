using System;
using System.Collections.Generic;
using System.Linq;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace WindsorIoc
{
    public class ContainerFactory
    {
        public void CreateWindsorContainer()
        {

            var container = new WindsorContainer();
            container.Register(Component.For<IYoav1>().ImplementedBy<Yoav1>());
            container.Register(Component.For<IYoav2>().ImplementedBy<Yoav2>());

            // Resolve an object of type ICompositionRoot (ask the container for an instance)
            // This is analagous to calling new() in a non-IoC application.
            var yoav2 = container.Resolve<IYoav2>();

        }

    }
}