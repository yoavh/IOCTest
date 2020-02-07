using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface ID11Resolve{}
public class D11Resolve: ID11Resolve{public D11Resolve(IMyContainer myContainer){var C10Resolve = myContainer.Container.Resolve<IC10Resolve>();var C11Resolve = myContainer.Container.Resolve<IC11Resolve>();var D00Resolve = myContainer.Container.Resolve<ID00Resolve>();var D01Resolve = myContainer.Container.Resolve<ID01Resolve>();var D10Resolve = myContainer.Container.Resolve<ID10Resolve>();}}
}

