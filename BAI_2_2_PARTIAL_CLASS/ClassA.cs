using System;
using System.Collections.Generic;
using System.Text;

namespace BAI_2_2_PARTIAL_CLASS
{
    /// <summary>
    /// Từ khoá partial cho phép khai báo các thành phần
    /// của 1 class ở những nơi khác nhau trong project
    /// </summary>
    public partial class DemoPartialClass
    {
        public int A;
        public int B;
        public void PhuongThuc1()
        {
            Console.WriteLine("Đây là phương thức 1");
        }
    }
}
