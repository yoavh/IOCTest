using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IZ10Resolve{}
public class Z10Resolve: IZ10Resolve{public Z10Resolve(IMyContainer myContainer){var Z00Resolve = myContainer.Container.Resolve<IZ00Resolve>();var Z01Resolve = myContainer.Container.Resolve<IZ01Resolve>();}}
}

