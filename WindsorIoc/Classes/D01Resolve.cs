using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface ID01Resolve{}
public class D01Resolve: ID01Resolve{public D01Resolve(IMyContainer myContainer){var C10Resolve = myContainer.Container.Resolve<IC10Resolve>();var C11Resolve = myContainer.Container.Resolve<IC11Resolve>();var D00Resolve = myContainer.Container.Resolve<ID00Resolve>();}}
}

