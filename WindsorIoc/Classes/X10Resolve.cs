using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IX10Resolve{}
public class X10Resolve: IX10Resolve{public X10Resolve(IMyContainer myContainer){var W10Resolve = myContainer.Container.Resolve<IW10Resolve>();var W11Resolve = myContainer.Container.Resolve<IW11Resolve>();var X00Resolve = myContainer.Container.Resolve<IX00Resolve>();var X01Resolve = myContainer.Container.Resolve<IX01Resolve>();}}
}

