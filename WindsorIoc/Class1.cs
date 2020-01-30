using System;

namespace WindsorIoc
{
    public class Class1
    {
        public void init()
        {
            var a1 = new Yoav1();
            var a2 = new Yoav2(a1);
        }
    }
}
