using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IX00Resolve{}
public class X00Resolve: IX00Resolve{public X00Resolve(IMyContainer myContainer){var W10Resolve = myContainer.Container.Resolve<IW10Resolve>();var W11Resolve = myContainer.Container.Resolve<IW11Resolve>();}}
}

