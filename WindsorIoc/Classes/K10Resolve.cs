using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IK10Resolve{}
public class K10Resolve: IK10Resolve{public K10Resolve(IMyContainer myContainer){var K00Resolve = myContainer.Container.Resolve<IK00Resolve>();var K01Resolve = myContainer.Container.Resolve<IK01Resolve>();}}
}

