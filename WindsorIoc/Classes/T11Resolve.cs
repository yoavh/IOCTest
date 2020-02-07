using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IT11Resolve{}
public class T11Resolve: IT11Resolve{public T11Resolve(IMyContainer myContainer){var R10Resolve = myContainer.Container.Resolve<IR10Resolve>();var R11Resolve = myContainer.Container.Resolve<IR11Resolve>();var S00Resolve = myContainer.Container.Resolve<IS00Resolve>();var S01Resolve = myContainer.Container.Resolve<IS01Resolve>();var S10Resolve = myContainer.Container.Resolve<IS10Resolve>();var S11Resolve = myContainer.Container.Resolve<IS11Resolve>();var T00Resolve = myContainer.Container.Resolve<IT00Resolve>();var T01Resolve = myContainer.Container.Resolve<IT01Resolve>();var T10Resolve = myContainer.Container.Resolve<IT10Resolve>();}}
}

