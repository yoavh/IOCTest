using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IQ00Resolve{}
public class Q00Resolve: IQ00Resolve{public Q00Resolve(IMyContainer myContainer){var P00Resolve = myContainer.Container.Resolve<IP00Resolve>();var P01Resolve = myContainer.Container.Resolve<IP01Resolve>();var P10Resolve = myContainer.Container.Resolve<IP10Resolve>();var P11Resolve = myContainer.Container.Resolve<IP11Resolve>();}}
}

