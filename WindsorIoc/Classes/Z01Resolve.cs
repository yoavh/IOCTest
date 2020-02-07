using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IZ01Resolve{}
public class Z01Resolve: IZ01Resolve{public Z01Resolve(IMyContainer myContainer){var Z00Resolve = myContainer.Container.Resolve<IZ00Resolve>();}}
}

