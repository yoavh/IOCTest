using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IZ00Resolve{}
public class Z00Resolve: IZ00Resolve{public Z00Resolve(IMyContainer myContainer){}}
}

