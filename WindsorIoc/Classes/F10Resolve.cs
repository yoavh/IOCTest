using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IF10Resolve{}
public class F10Resolve: IF10Resolve{public F10Resolve(IMyContainer myContainer){var F00Resolve = myContainer.Container.Resolve<IF00Resolve>();var F01Resolve = myContainer.Container.Resolve<IF01Resolve>();}}
}

