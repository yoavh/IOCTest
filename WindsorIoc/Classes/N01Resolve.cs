using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IN01Resolve{}
public class N01Resolve: IN01Resolve{public N01Resolve(IMyContainer myContainer){var M10Resolve = myContainer.Container.Resolve<IM10Resolve>();var M11Resolve = myContainer.Container.Resolve<IM11Resolve>();var N00Resolve = myContainer.Container.Resolve<IN00Resolve>();}}
}

