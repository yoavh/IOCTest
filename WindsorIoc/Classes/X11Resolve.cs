using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IX11Resolve{}
public class X11Resolve: IX11Resolve{public X11Resolve(IMyContainer myContainer){var W10Resolve = myContainer.Container.Resolve<IW10Resolve>();var W11Resolve = myContainer.Container.Resolve<IW11Resolve>();var X00Resolve = myContainer.Container.Resolve<IX00Resolve>();var X01Resolve = myContainer.Container.Resolve<IX01Resolve>();var X10Resolve = myContainer.Container.Resolve<IX10Resolve>();}}
}

