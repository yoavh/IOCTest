using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IN10Resolve{}
public class N10Resolve: IN10Resolve{public N10Resolve(IMyContainer myContainer){var M10Resolve = myContainer.Container.Resolve<IM10Resolve>();var M11Resolve = myContainer.Container.Resolve<IM11Resolve>();var N00Resolve = myContainer.Container.Resolve<IN00Resolve>();var N01Resolve = myContainer.Container.Resolve<IN01Resolve>();}}
}

