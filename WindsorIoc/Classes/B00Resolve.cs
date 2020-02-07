using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IB00Resolve{}
public class B00Resolve: IB00Resolve{public B00Resolve(IMyContainer myContainer){var A00Resolve = myContainer.Container.Resolve<IA00Resolve>();var A01Resolve = myContainer.Container.Resolve<IA01Resolve>();var A10Resolve = myContainer.Container.Resolve<IA10Resolve>();var A11Resolve = myContainer.Container.Resolve<IA11Resolve>();}}
}

