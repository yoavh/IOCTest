using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IU10Resolve{}
public class U10Resolve: IU10Resolve{public U10Resolve(IMyContainer myContainer){var U00Resolve = myContainer.Container.Resolve<IU00Resolve>();var U01Resolve = myContainer.Container.Resolve<IU01Resolve>();}}
}

