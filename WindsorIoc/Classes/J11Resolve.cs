using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace WindsorIoc{
public interface IJ11Resolve{}
public class J11Resolve: IJ11Resolve{public J11Resolve(IMyContainer myContainer){var H10Resolve = myContainer.Container.Resolve<IH10Resolve>();var H11Resolve = myContainer.Container.Resolve<IH11Resolve>();var I00Resolve = myContainer.Container.Resolve<II00Resolve>();var I01Resolve = myContainer.Container.Resolve<II01Resolve>();var I10Resolve = myContainer.Container.Resolve<II10Resolve>();var I11Resolve = myContainer.Container.Resolve<II11Resolve>();var J00Resolve = myContainer.Container.Resolve<IJ00Resolve>();var J01Resolve = myContainer.Container.Resolve<IJ01Resolve>();var J10Resolve = myContainer.Container.Resolve<IJ10Resolve>();}}
}

