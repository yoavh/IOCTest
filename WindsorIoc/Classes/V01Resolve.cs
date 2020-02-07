using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IV01Resolve{}
public class V01Resolve: IV01Resolve{public V01Resolve(IMyContainer myContainer){var U00Resolve = myContainer.Container.Resolve<IU00Resolve>();var U01Resolve = myContainer.Container.Resolve<IU01Resolve>();var U10Resolve = myContainer.Container.Resolve<IU10Resolve>();var U11Resolve = myContainer.Container.Resolve<IU11Resolve>();var V00Resolve = myContainer.Container.Resolve<IV00Resolve>();}}
}

