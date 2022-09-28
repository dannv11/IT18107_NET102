using System;
using System.Text;

namespace BAI_2_2_PARTIAL_CLASS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            #region Partial class
            //DemoPartialClass demoPartialClass = new DemoPartialClass();
            //demoPartialClass.A = 1;
            //demoPartialClass.B = 2;
            //demoPartialClass.C = 3;
            //demoPartialClass.PhuongThuc1();
            //demoPartialClass.method2();
            #endregion

            #region Nester class
            // Nester class hay Nester type là chỉ
            // việc khai báo 1 class bên trong thân của 1 class khác
            // Để truy cập vào Nester class
            // ta gọi Container.Nester
            Container.Nester demo = new Container.Nester(5);
            demo.inA();
            #endregion
        }
    }
}
