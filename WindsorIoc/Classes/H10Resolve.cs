using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IH10Resolve{}
public class H10Resolve: IH10Resolve{public H10Resolve(IMyContainer myContainer){}}
}

