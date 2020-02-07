using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface II00Resolve{}
public class I00Resolve: II00Resolve{public I00Resolve(IMyContainer myContainer){var H10Resolve = myContainer.Container.Resolve<IH10Resolve>();var H11Resolve = myContainer.Container.Resolve<IH11Resolve>();}}
}

