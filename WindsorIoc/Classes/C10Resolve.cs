using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IC10Resolve{}
public class C10Resolve: IC10Resolve{public C10Resolve(IMyContainer myContainer){}}
}

