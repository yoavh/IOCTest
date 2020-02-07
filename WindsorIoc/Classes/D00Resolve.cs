using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface ID00Resolve{}
public class D00Resolve: ID00Resolve{public D00Resolve(IMyContainer myContainer){var C10Resolve = myContainer.Container.Resolve<IC10Resolve>();var C11Resolve = myContainer.Container.Resolve<IC11Resolve>();}}
}

