using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IS11Resolve{}
public class S11Resolve: IS11Resolve{public S11Resolve(IMyContainer myContainer){var R10Resolve = myContainer.Container.Resolve<IR10Resolve>();var R11Resolve = myContainer.Container.Resolve<IR11Resolve>();var S00Resolve = myContainer.Container.Resolve<IS00Resolve>();var S01Resolve = myContainer.Container.Resolve<IS01Resolve>();var S10Resolve = myContainer.Container.Resolve<IS10Resolve>();}}
}

