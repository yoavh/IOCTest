using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IW00Resolve{}
public class W00Resolve: IW00Resolve{public W00Resolve(IMyContainer myContainer){var U00Resolve = myContainer.Container.Resolve<IU00Resolve>();var U01Resolve = myContainer.Container.Resolve<IU01Resolve>();var U10Resolve = myContainer.Container.Resolve<IU10Resolve>();var U11Resolve = myContainer.Container.Resolve<IU11Resolve>();var V00Resolve = myContainer.Container.Resolve<IV00Resolve>();var V01Resolve = myContainer.Container.Resolve<IV01Resolve>();var V10Resolve = myContainer.Container.Resolve<IV10Resolve>();var V11Resolve = myContainer.Container.Resolve<IV11Resolve>();}}
}

