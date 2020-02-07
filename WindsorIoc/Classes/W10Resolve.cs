using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IW10Resolve{}
public class W10Resolve: IW10Resolve{public W10Resolve(IMyContainer myContainer){}}
}

