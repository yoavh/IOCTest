using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IN00Resolve{}
public class N00Resolve: IN00Resolve{public N00Resolve(IMyContainer myContainer){var M10Resolve = myContainer.Container.Resolve<IM10Resolve>();var M11Resolve = myContainer.Container.Resolve<IM11Resolve>();}}
}

