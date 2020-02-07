using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IV11Resolve{}
public class V11Resolve: IV11Resolve{public V11Resolve(IMyContainer myContainer){var U00Resolve = myContainer.Container.Resolve<IU00Resolve>();var U01Resolve = myContainer.Container.Resolve<IU01Resolve>();var U10Resolve = myContainer.Container.Resolve<IU10Resolve>();var U11Resolve = myContainer.Container.Resolve<IU11Resolve>();var V00Resolve = myContainer.Container.Resolve<IV00Resolve>();var V01Resolve = myContainer.Container.Resolve<IV01Resolve>();var V10Resolve = myContainer.Container.Resolve<IV10Resolve>();}}
}

