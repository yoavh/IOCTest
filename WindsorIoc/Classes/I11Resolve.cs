using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface II11Resolve{}
public class I11Resolve: II11Resolve{public I11Resolve(IMyContainer myContainer){var H10Resolve = myContainer.Container.Resolve<IH10Resolve>();var H11Resolve = myContainer.Container.Resolve<IH11Resolve>();var I00Resolve = myContainer.Container.Resolve<II00Resolve>();var I01Resolve = myContainer.Container.Resolve<II01Resolve>();var I10Resolve = myContainer.Container.Resolve<II10Resolve>();}}
}

