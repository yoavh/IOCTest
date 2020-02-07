using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IP00Resolve{}
public class P00Resolve: IP00Resolve{public P00Resolve(IMyContainer myContainer){}}
}

