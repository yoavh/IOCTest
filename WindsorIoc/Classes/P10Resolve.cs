using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IP10Resolve{}
public class P10Resolve: IP10Resolve{public P10Resolve(IMyContainer myContainer){var P00Resolve = myContainer.Container.Resolve<IP00Resolve>();var P01Resolve = myContainer.Container.Resolve<IP01Resolve>();}}
}

