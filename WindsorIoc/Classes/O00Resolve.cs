using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IO00Resolve{}
public class O00Resolve: IO00Resolve{public O00Resolve(IMyContainer myContainer){var M10Resolve = myContainer.Container.Resolve<IM10Resolve>();var M11Resolve = myContainer.Container.Resolve<IM11Resolve>();var N00Resolve = myContainer.Container.Resolve<IN00Resolve>();var N01Resolve = myContainer.Container.Resolve<IN01Resolve>();var N10Resolve = myContainer.Container.Resolve<IN10Resolve>();var N11Resolve = myContainer.Container.Resolve<IN11Resolve>();}}
}

