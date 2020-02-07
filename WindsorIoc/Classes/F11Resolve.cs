using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IF11Resolve{}
public class F11Resolve: IF11Resolve{public F11Resolve(IMyContainer myContainer){var F00Resolve = myContainer.Container.Resolve<IF00Resolve>();var F01Resolve = myContainer.Container.Resolve<IF01Resolve>();var F10Resolve = myContainer.Container.Resolve<IF10Resolve>();}}
}

