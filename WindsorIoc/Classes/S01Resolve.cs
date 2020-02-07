using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IS01Resolve{}
public class S01Resolve: IS01Resolve{public S01Resolve(IMyContainer myContainer){var R10Resolve = myContainer.Container.Resolve<IR10Resolve>();var R11Resolve = myContainer.Container.Resolve<IR11Resolve>();var S00Resolve = myContainer.Container.Resolve<IS00Resolve>();}}
}

