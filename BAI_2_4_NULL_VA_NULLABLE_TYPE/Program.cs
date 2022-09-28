using System;
using System.Collections.Generic;
using System.Text;

namespace BAI_2_4_NULL_VA_NULLABLE_TYPE
{

    internal class Program
    {
        #region Định nghĩa
        /*
        * 1. Từ khóa null
        *    + null là một giá trị cố định nó biểu thị không có đối tượng nào cả, có nghĩa là biến có giá trị null không có tham chiếu (trỏ) đến đối tượng nào (không có gì).
             + null chỉ có thể gán được cho các biến kiểu tham chiếu (biến có kiểu dữ liệu là các lớp), không thể gán null cho những biến có kiểu dữ liệu dạng tham trị như int, float, bool ...
        */

        /*
         *2. Sử dụng nullable
         *    + Nếu bạn muốn sử dụng các kiểu dữ liệu nguyên tố như int, float, double ... như là một kiểu dữ liệu dạng tham chiếu, có thể gán giá trị null cho nó, có thể sử dụng như đối tượng ... thì khai báo nó có khả năng nullable, khi biến nullable có giá trị thì đọc giá trị bằng truy cập thành viên .Value, cách làm như sau:
         *    + Khi khai báo biến có khả năng nullable thì thêm vào ? sau kiểu dữ liệu      
         */
        #endregion

        public static void Vidu1()
        {
            // Có thể gán giá trị null cho một kiểu tham chiếu
            List<string> strings = null;

            // nhưng không thể gán giá trị null cho kiểu tham trị
            // Cannot convert null to non-nullable type.
            // int a = null;

        }



        #region Phần 2 NULLABLE TYPED
        /*2.  NULLABLE TYPED
            + Cú pháp: 
                - Nullable<T> tên biến;
                - T? tên biến;
            + Cần gán gia trị cho biến khi khai báo nếu không sẽ bị lỗi và nên kiểm tra giá tị trước khi dùng bằng HasValue
            + Dùng phương thức GetValueOrDefault() để lấy giá mặc định của kiểu dữ liệu
            + Dùng toán tử ?? thực hiện gán Nullable Type cho Non-Nullable Type
            */
        #endregion
        public static void vidu2()
        {
            // Khai báo nullable
            Nullable<int> diem = null;
            long? chieuCao = null;
            int diemThuc = -1;
            // Dùng [NUllable var].Hasvalue để kiểm tra
            // xem biến đó có đang chứa giá trị hay không
            // (Nó có đang khác null hay không)
            //diemThuc = diem.Value;
           // Console.WriteLine($"Điểm = "+diemThuc);


           diem = 8;
            if (diem.HasValue)
            {
                diemThuc = diem.Value;
            }
            Console.WriteLine($"Điểm = " + diemThuc);
            diem = null;
            // Toán tử ?? dùng để kiểm tra 
            // Nếu điểm # null diemThuc = diem
            // Nếu điểm = null diemThuc = 9
            diemThuc = diem ?? 9;
            Console.WriteLine($"Điểm = " + diemThuc);

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //vidu2();

            ConVat? meo = null;
            ConVat cho = new ConVat("Chó", null);
            string tenMeo = "aaaaaa", tuoiCho;

            tenMeo = meo?.Name;

            Console.WriteLine(tenMeo);
        }
    }
}
