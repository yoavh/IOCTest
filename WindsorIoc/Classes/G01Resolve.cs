using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IG01Resolve{}
public class G01Resolve: IG01Resolve{public G01Resolve(IMyContainer myContainer){var F00Resolve = myContainer.Container.Resolve<IF00Resolve>();var F01Resolve = myContainer.Container.Resolve<IF01Resolve>();var F10Resolve = myContainer.Container.Resolve<IF10Resolve>();var F11Resolve = myContainer.Container.Resolve<IF11Resolve>();var G00Resolve = myContainer.Container.Resolve<IG00Resolve>();}}
}

