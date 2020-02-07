using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IE10Resolve{}
public class E10Resolve: IE10Resolve{public E10Resolve(IMyContainer myContainer){var C10Resolve = myContainer.Container.Resolve<IC10Resolve>();var C11Resolve = myContainer.Container.Resolve<IC11Resolve>();var D00Resolve = myContainer.Container.Resolve<ID00Resolve>();var D01Resolve = myContainer.Container.Resolve<ID01Resolve>();var D10Resolve = myContainer.Container.Resolve<ID10Resolve>();var D11Resolve = myContainer.Container.Resolve<ID11Resolve>();var E00Resolve = myContainer.Container.Resolve<IE00Resolve>();var E01Resolve = myContainer.Container.Resolve<IE01Resolve>();}}
}

