namespace WindsorIoc
{
    public interface IYoav2 { }
    public class Yoav2 : IYoav2
    {
        public Yoav2(IYoav1 yoav1) { }
    }
}
