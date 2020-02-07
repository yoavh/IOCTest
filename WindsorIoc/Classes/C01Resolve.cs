using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IC01Resolve{}
public class C01Resolve: IC01Resolve{public C01Resolve(IMyContainer myContainer){var A00Resolve = myContainer.Container.Resolve<IA00Resolve>();var A01Resolve = myContainer.Container.Resolve<IA01Resolve>();var A10Resolve = myContainer.Container.Resolve<IA10Resolve>();var A11Resolve = myContainer.Container.Resolve<IA11Resolve>();var B00Resolve = myContainer.Container.Resolve<IB00Resolve>();var B01Resolve = myContainer.Container.Resolve<IB01Resolve>();var B10Resolve = myContainer.Container.Resolve<IB10Resolve>();var B11Resolve = myContainer.Container.Resolve<IB11Resolve>();var C00Resolve = myContainer.Container.Resolve<IC00Resolve>();}}
}

