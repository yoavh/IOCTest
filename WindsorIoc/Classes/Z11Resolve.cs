using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IZ11Resolve{}
public class Z11Resolve: IZ11Resolve{public Z11Resolve(IMyContainer myContainer){var Z00Resolve = myContainer.Container.Resolve<IZ00Resolve>();var Z01Resolve = myContainer.Container.Resolve<IZ01Resolve>();var Z10Resolve = myContainer.Container.Resolve<IZ10Resolve>();}}
}

