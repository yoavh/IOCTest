using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IO11Resolve{}
public class O11Resolve: IO11Resolve{public O11Resolve(IMyContainer myContainer){var M10Resolve = myContainer.Container.Resolve<IM10Resolve>();var M11Resolve = myContainer.Container.Resolve<IM11Resolve>();var N00Resolve = myContainer.Container.Resolve<IN00Resolve>();var N01Resolve = myContainer.Container.Resolve<IN01Resolve>();var N10Resolve = myContainer.Container.Resolve<IN10Resolve>();var N11Resolve = myContainer.Container.Resolve<IN11Resolve>();var O00Resolve = myContainer.Container.Resolve<IO00Resolve>();var O01Resolve = myContainer.Container.Resolve<IO01Resolve>();var O10Resolve = myContainer.Container.Resolve<IO10Resolve>();}}
}

