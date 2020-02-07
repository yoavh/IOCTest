using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IM11Resolve{}
public class M11Resolve: IM11Resolve{public M11Resolve(IMyContainer myContainer){var M10Resolve = myContainer.Container.Resolve<IM10Resolve>();}}
}

