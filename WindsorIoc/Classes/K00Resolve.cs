using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IK00Resolve{}
public class K00Resolve: IK00Resolve{public K00Resolve(IMyContainer myContainer){}}
}

