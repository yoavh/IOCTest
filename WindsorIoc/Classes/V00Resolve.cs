using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IV00Resolve{}
public class V00Resolve: IV00Resolve{public V00Resolve(IMyContainer myContainer){var U00Resolve = myContainer.Container.Resolve<IU00Resolve>();var U01Resolve = myContainer.Container.Resolve<IU01Resolve>();var U10Resolve = myContainer.Container.Resolve<IU10Resolve>();var U11Resolve = myContainer.Container.Resolve<IU11Resolve>();}}
}

