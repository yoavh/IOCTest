using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IB11Resolve{}
public class B11Resolve: IB11Resolve{public B11Resolve(IMyContainer myContainer){var A00Resolve = myContainer.Container.Resolve<IA00Resolve>();var A01Resolve = myContainer.Container.Resolve<IA01Resolve>();var A10Resolve = myContainer.Container.Resolve<IA10Resolve>();var A11Resolve = myContainer.Container.Resolve<IA11Resolve>();var B00Resolve = myContainer.Container.Resolve<IB00Resolve>();var B01Resolve = myContainer.Container.Resolve<IB01Resolve>();var B10Resolve = myContainer.Container.Resolve<IB10Resolve>();}}
}

