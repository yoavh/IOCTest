using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface ID10Resolve{}
public class D10Resolve: ID10Resolve{public D10Resolve(IMyContainer myContainer){var C10Resolve = myContainer.Container.Resolve<IC10Resolve>();var C11Resolve = myContainer.Container.Resolve<IC11Resolve>();var D00Resolve = myContainer.Container.Resolve<ID00Resolve>();var D01Resolve = myContainer.Container.Resolve<ID01Resolve>();}}
}

