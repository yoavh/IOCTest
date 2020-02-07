using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface II10Resolve{}
public class I10Resolve: II10Resolve{public I10Resolve(IMyContainer myContainer){var H10Resolve = myContainer.Container.Resolve<IH10Resolve>();var H11Resolve = myContainer.Container.Resolve<IH11Resolve>();var I00Resolve = myContainer.Container.Resolve<II00Resolve>();var I01Resolve = myContainer.Container.Resolve<II01Resolve>();}}
}

