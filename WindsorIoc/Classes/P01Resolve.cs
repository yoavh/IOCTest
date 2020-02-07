using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IP01Resolve{}
public class P01Resolve: IP01Resolve{public P01Resolve(IMyContainer myContainer){var P00Resolve = myContainer.Container.Resolve<IP00Resolve>();}}
}

