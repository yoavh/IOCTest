using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IF01Resolve{}
public class F01Resolve: IF01Resolve{public F01Resolve(IMyContainer myContainer){var F00Resolve = myContainer.Container.Resolve<IF00Resolve>();}}
}

