using System;
using System.Text;

namespace BAI_1_1_DELEGATE
{
    internal class Program
    {
        #region Định nghĩa Delegate
        /*
      * Định nghĩa:
          * ❑Delegate là một biến chứa tham chiếu đến phương thức cần thực thi.
            ❑Một delegate có thể trỏ tới một hoặc nhiều phương thức
            ❑Delegate có thể gọi bất kỳ phương thức nào nó trỏ tới tại thời điểm thực thi
            ❑
      * + Có thể khai báo trong namespace hoặc khai báo trong class
      * + Khi khai báo giống như khai báo một phương thức
      * + Công thức:
      *      <phạm vi truy cập> delegate <kiểu phương thức> <tên>(<Tham số>);
      */


        #endregion
        //Khai báo 1 delegate
        public delegate void ThongBao(string msg);

        public static void ThongTin1(string noidung)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ThongTin1: " + noidung);
            Console.ResetColor();
        }
        public static void ThongTin2(string noidung)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ThongTin2: " + noidung);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Phần 1: Khởi tao delegate null

            Console.WriteLine("==Phần 1: Khởi tao delegate null==");
            ThongBao thongbao = null;//Khai báo 1 delegate gán = null
            thongbao = ThongTin1;//Tham chiếu đến phương thức thì delegate sẽ trỏ đến phương thức đó.
            thongbao?.Invoke("Chào các bạn đến C# 2");//? Dùng để kiểm tra xem phương thức đó có null hay không và nếu không thì sẽ thực thi

            #endregion
            #region Phần 2: Khởi tạo 1 delegate
            Console.WriteLine("==Phần 2: Khởi tạo 1 delegate==");
            ThongBao thongbao1 = new ThongBao(ThongTin2);
            thongbao1("Thông báo 2");

            #endregion

            #region Phần 3:  Multicast Delegate
            Console.WriteLine("==Phần 3:  Multicast Delegate==");
            ThongBao thongbao2 = new ThongBao(ThongTin1);
            ThongBao thongbao3 = new ThongBao(ThongTin2);
            ThongBao multicast = thongbao2 + thongbao3;
            multicast -= thongbao3;
            multicast += thongbao3;
            multicast += thongbao3;
            multicast += thongbao3;
            multicast("multicast");

            #endregion

            #region Phần 4: Delegate Callback
            Console.WriteLine("==Phần 4: Delegate Callback==");
            DelegateCallBack dcl = new DelegateCallBack(ThongTin3);
            CallBackFunc(dcl);

            #endregion

        }

        #region Phần 4: Delegate Callback

        public delegate void DelegateCallBack(int a);
        public static void ThongTin3(int temp)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ThongTin2: " + temp);
            Console.ResetColor();
        }

        public static void CallBackFunc(DelegateCallBack delegatecallback)
        {
            Console.WriteLine("Mời bạn nhập số nguyên: ");
            int a = Convert.ToInt32(Console.ReadLine());
            delegatecallback(a);

        }

        #endregion
    }
}
