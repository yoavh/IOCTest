using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IL01Resolve{}
public class L01Resolve: IL01Resolve{public L01Resolve(IMyContainer myContainer){var K00Resolve = myContainer.Container.Resolve<IK00Resolve>();var K01Resolve = myContainer.Container.Resolve<IK01Resolve>();var K10Resolve = myContainer.Container.Resolve<IK10Resolve>();var K11Resolve = myContainer.Container.Resolve<IK11Resolve>();var L00Resolve = myContainer.Container.Resolve<IL00Resolve>();}}
}

