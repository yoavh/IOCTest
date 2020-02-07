using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IR11Resolve{}
public class R11Resolve: IR11Resolve{public R11Resolve(IMyContainer myContainer){var R10Resolve = myContainer.Container.Resolve<IR10Resolve>();}}
}

