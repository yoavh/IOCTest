using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IY01Resolve{}
public class Y01Resolve: IY01Resolve{public Y01Resolve(IMyContainer myContainer){var W10Resolve = myContainer.Container.Resolve<IW10Resolve>();var W11Resolve = myContainer.Container.Resolve<IW11Resolve>();var X00Resolve = myContainer.Container.Resolve<IX00Resolve>();var X01Resolve = myContainer.Container.Resolve<IX01Resolve>();var X10Resolve = myContainer.Container.Resolve<IX10Resolve>();var X11Resolve = myContainer.Container.Resolve<IX11Resolve>();var Y00Resolve = myContainer.Container.Resolve<IY00Resolve>();}}
}

