using System;
using System.IO;

namespace BAI_2_0_GENERIC_TYPE
{
    internal class Program
    {
        #region Tham trị và Tham chiếu
        /*
         * Có hai hình thức truyền tham số cho phương
         * thức khi nó được gọi là tham trị và tham chiếu:    
            + Tham trị là cách thức mặc định
        khi tham số đó là kiểu giá trị.
        Có nghĩa là gán tham số bằng một biến,
        thì giá trị của biến được copy và
        sử dụng trong phương thức như biến cục bộ,
        còn bản thân biến bên ngoài không hề ảnh hưởng.
            + Tham chiếu là cách thức mặc định
        khi tham số đó là kiểu tham chiếu
        , thì bản thân biến ở tham số sẽ được 
        hàm sử dụng trực tiếp (tham chiếu) chứ không tạo ra một biến cục bộ trong hàm, nên nó có tác động trực tiếp đến biến này bên ngoài.
                - Trong phần này mở rộng thêm, nếu muốn biến kiểu giá trị nhưng được truyền vào phương thức dạng tham chiếu (giống cách thức biến tham chiếu) thì khai báo tham số ở phương thức, cũng như khi gọi cần cho thêm từ khóa ref
         */
        #endregion

        //VD  TRUYỀN THAM TRỊ VÀ TRUYỀN THAM CHIẾU
        public static void truyenThamTri(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a = {a}, b = {b}");
        }
        public static void truyenThamChieu(ref int a, ref int b )
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a = {a}, b = {b}");
        }

        // truyền tham chiếu generic
        public static void truyenThamChieuGeneric<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a = {a}, b = {b}");
        }

        /* ❑ Generic trong C# cho phép định nghĩa một phương thức,một lớp mà không cần chỉ ra đối số kiểu dữ liệu là gì.
                ❑ Generic cũng là một kiểu dữ liệu trong C# như int, string, bool,… nhưng nó là một kiểu dữ liệu “tự do”, tùy vào mục đích sử dụng mà nó có thể đại diện cho tất cả các kiểu dữ liệu còn lại.
                ❑ Có thể định nghĩa lớp, interface, phương thức, delegate như là kiểu generic
                */
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            truyenThamTri(a, b);
            Console.WriteLine("Sau khi goi truyen tham tri");
            Console.WriteLine($"a = {a}, b = {b}");
            //truyenThamChieu(ref a,ref b);
            //Console.WriteLine("Sau khi goi truyen tham chieu");
            //Console.WriteLine($"a = {a}, b = {b}");
            truyenThamChieuGeneric<int>(ref a, ref b);
            Console.WriteLine("Sau khi goi truyen tham chieu");
            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
