using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IX01Resolve{}
public class X01Resolve: IX01Resolve{public X01Resolve(IMyContainer myContainer){var W10Resolve = myContainer.Container.Resolve<IW10Resolve>();var W11Resolve = myContainer.Container.Resolve<IW11Resolve>();var X00Resolve = myContainer.Container.Resolve<IX00Resolve>();}}
}

