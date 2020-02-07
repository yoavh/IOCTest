using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc
{
    public interface IMyContainer
    {
        WindsorContainer Container { get; }
        void Init(WindsorContainer container);
    }

    public class MyContainer : IMyContainer
    {
        WindsorContainer _container;
        public WindsorContainer Container => _container;
        public void Init(WindsorContainer container)
        {
            _container = container;
        }
    }
}

// container.Register(Component.For<IMyContainer>().ImplementedBy<MyContainer>().LifestyleSingleton());
// var mycontainer = container.Resolve<IMyContainer>();
//             mycontainer.Init(container);