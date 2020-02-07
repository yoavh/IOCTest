using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IQ11Resolve{}
public class Q11Resolve: IQ11Resolve{public Q11Resolve(IMyContainer myContainer){var P00Resolve = myContainer.Container.Resolve<IP00Resolve>();var P01Resolve = myContainer.Container.Resolve<IP01Resolve>();var P10Resolve = myContainer.Container.Resolve<IP10Resolve>();var P11Resolve = myContainer.Container.Resolve<IP11Resolve>();var Q00Resolve = myContainer.Container.Resolve<IQ00Resolve>();var Q01Resolve = myContainer.Container.Resolve<IQ01Resolve>();var Q10Resolve = myContainer.Container.Resolve<IQ10Resolve>();}}
}

