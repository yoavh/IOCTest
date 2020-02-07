using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IM01Resolve{}
public class M01Resolve: IM01Resolve{public M01Resolve(IMyContainer myContainer){var K00Resolve = myContainer.Container.Resolve<IK00Resolve>();var K01Resolve = myContainer.Container.Resolve<IK01Resolve>();var K10Resolve = myContainer.Container.Resolve<IK10Resolve>();var K11Resolve = myContainer.Container.Resolve<IK11Resolve>();var L00Resolve = myContainer.Container.Resolve<IL00Resolve>();var L01Resolve = myContainer.Container.Resolve<IL01Resolve>();var L10Resolve = myContainer.Container.Resolve<IL10Resolve>();var L11Resolve = myContainer.Container.Resolve<IL11Resolve>();var M00Resolve = myContainer.Container.Resolve<IM00Resolve>();}}
}

