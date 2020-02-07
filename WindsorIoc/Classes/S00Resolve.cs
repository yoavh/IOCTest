using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IS00Resolve{}
public class S00Resolve: IS00Resolve{public S00Resolve(IMyContainer myContainer){var R10Resolve = myContainer.Container.Resolve<IR10Resolve>();var R11Resolve = myContainer.Container.Resolve<IR11Resolve>();}}
}

