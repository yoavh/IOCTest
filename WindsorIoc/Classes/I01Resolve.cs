using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface II01Resolve{}
public class I01Resolve: II01Resolve{public I01Resolve(IMyContainer myContainer){var H10Resolve = myContainer.Container.Resolve<IH10Resolve>();var H11Resolve = myContainer.Container.Resolve<IH11Resolve>();var I00Resolve = myContainer.Container.Resolve<II00Resolve>();}}
}

