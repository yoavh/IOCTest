using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IT10Resolve{}
public class T10Resolve: IT10Resolve{public T10Resolve(IMyContainer myContainer){var R10Resolve = myContainer.Container.Resolve<IR10Resolve>();var R11Resolve = myContainer.Container.Resolve<IR11Resolve>();var S00Resolve = myContainer.Container.Resolve<IS00Resolve>();var S01Resolve = myContainer.Container.Resolve<IS01Resolve>();var S10Resolve = myContainer.Container.Resolve<IS10Resolve>();var S11Resolve = myContainer.Container.Resolve<IS11Resolve>();var T00Resolve = myContainer.Container.Resolve<IT00Resolve>();var T01Resolve = myContainer.Container.Resolve<IT01Resolve>();}}
}

