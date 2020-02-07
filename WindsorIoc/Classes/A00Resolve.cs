using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IA00Resolve{}
public class A00Resolve: IA00Resolve{public A00Resolve(IMyContainer myContainer){}}
}

