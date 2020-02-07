using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IG00Resolve{}
public class G00Resolve: IG00Resolve{public G00Resolve(IMyContainer myContainer){var F00Resolve = myContainer.Container.Resolve<IF00Resolve>();var F01Resolve = myContainer.Container.Resolve<IF01Resolve>();var F10Resolve = myContainer.Container.Resolve<IF10Resolve>();var F11Resolve = myContainer.Container.Resolve<IF11Resolve>();}}
}

