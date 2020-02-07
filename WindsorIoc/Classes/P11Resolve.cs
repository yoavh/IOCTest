using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IP11Resolve{}
public class P11Resolve: IP11Resolve{public P11Resolve(IMyContainer myContainer){var P00Resolve = myContainer.Container.Resolve<IP00Resolve>();var P01Resolve = myContainer.Container.Resolve<IP01Resolve>();var P10Resolve = myContainer.Container.Resolve<IP10Resolve>();}}
}

