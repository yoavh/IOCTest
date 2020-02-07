using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IW11Resolve{}
public class W11Resolve: IW11Resolve{public W11Resolve(IMyContainer myContainer){var W10Resolve = myContainer.Container.Resolve<IW10Resolve>();}}
}

