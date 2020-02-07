using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IY10Resolve{}
public class Y10Resolve: IY10Resolve{public Y10Resolve(IMyContainer myContainer){var W10Resolve = myContainer.Container.Resolve<IW10Resolve>();var W11Resolve = myContainer.Container.Resolve<IW11Resolve>();var X00Resolve = myContainer.Container.Resolve<IX00Resolve>();var X01Resolve = myContainer.Container.Resolve<IX01Resolve>();var X10Resolve = myContainer.Container.Resolve<IX10Resolve>();var X11Resolve = myContainer.Container.Resolve<IX11Resolve>();var Y00Resolve = myContainer.Container.Resolve<IY00Resolve>();var Y01Resolve = myContainer.Container.Resolve<IY01Resolve>();}}
}

