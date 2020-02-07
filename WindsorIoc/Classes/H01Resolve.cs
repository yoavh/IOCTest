using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IH01Resolve{}
public class H01Resolve: IH01Resolve{public H01Resolve(IMyContainer myContainer){var F00Resolve = myContainer.Container.Resolve<IF00Resolve>();var F01Resolve = myContainer.Container.Resolve<IF01Resolve>();var F10Resolve = myContainer.Container.Resolve<IF10Resolve>();var F11Resolve = myContainer.Container.Resolve<IF11Resolve>();var G00Resolve = myContainer.Container.Resolve<IG00Resolve>();var G01Resolve = myContainer.Container.Resolve<IG01Resolve>();var G10Resolve = myContainer.Container.Resolve<IG10Resolve>();var G11Resolve = myContainer.Container.Resolve<IG11Resolve>();var H00Resolve = myContainer.Container.Resolve<IH00Resolve>();}}
}

