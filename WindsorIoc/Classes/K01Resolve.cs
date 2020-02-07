using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IK01Resolve{}
public class K01Resolve: IK01Resolve{public K01Resolve(IMyContainer myContainer){var K00Resolve = myContainer.Container.Resolve<IK00Resolve>();}}
}

