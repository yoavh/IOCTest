using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IO01Resolve{}
public class O01Resolve: IO01Resolve{public O01Resolve(IMyContainer myContainer){var M10Resolve = myContainer.Container.Resolve<IM10Resolve>();var M11Resolve = myContainer.Container.Resolve<IM11Resolve>();var N00Resolve = myContainer.Container.Resolve<IN00Resolve>();var N01Resolve = myContainer.Container.Resolve<IN01Resolve>();var N10Resolve = myContainer.Container.Resolve<IN10Resolve>();var N11Resolve = myContainer.Container.Resolve<IN11Resolve>();var O00Resolve = myContainer.Container.Resolve<IO00Resolve>();}}
}

