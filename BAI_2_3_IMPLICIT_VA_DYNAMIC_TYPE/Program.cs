using System;
using System.Text;

namespace BAI_2_3_IMPLICITLY_VA_DYNAMIC_TYPE
{
    internal class Program
    { /*
       * Phần 1: Implicitly,Dynamic
       *          1.1 Implicitly (KIỀU NGẦM ĐỊNH):
       *             ❑Khai báo biến kiểu ngầm định (khai báo không tường minh) là biến được khai báo mà không cần phải chỉ ra kiểu dữ liệu
                     ❑Kiểu dữ liệu của biến sẽ được xác định bởi trình biên dịch dựa vào biểu thức được gán khi khai báo biến
                     ❑Sử dụng từ khóa “var” khi khai báo và cần khởi tạo giá trị
                  1.2 Công thức:
                      var varialble_name = value;
                  1.3 Hạn chế:
                     + Không thể sử dụng từ khóa var bên ngoài phạm vi của một method
                     + Không thể khởi tạo giá trị là null.
                     + Biến phải được khởi tạo giá trị khi nó được khai báo 
                     + Nếu biến được gán giá trị, thì kiểu dữ liệu phải giống        nhau
                     + Giá trị khởi tạo phải là một biểu thức. Giá trị khởi tạo     không được là một đối tượng hay tập hợp các giá trị. Nhưng nó có thể sử dụng toán tử new bởi một đối tượng hoặc tập hợp các giá trị.
                  2.1 Dynamic
                      Kiểu động - ngầm định - khai báo với từ khóa dynamic,
        thì kiểu thực sự của biến đó được xác định bằng đối tượng
        gán vào ở thời điểm chạy (khác với kiểu ngầm định var
        kiểu xác định ngay        thời điểm biên dịch)
       */

        #region implicitly

        public static void ViDu1()
        {
            // Không gán giá trị khi khai báo
            // kiểu ngầm định ide sẽ báo lỗi
            //var aString;

            var aString = "something";
            var aInt = 1;
            // Biến kiểu tường minh có thể gán giá trị cho null
            string nullString = null;
            // Kiểu ngầm định thì không
            //var nullVar = null;
            // Không thể gán giá trị
            // kiểu khác cho kiểu ngầm định sau khi khai báo
            // aInt = "aaaa";
        }
        // Khi khai báo kiểu ngầm định
        // bên ngoài một phương thức thì sẽ báo lỗi
        // var a = 1;
        #endregion

        #region dynamic
        public static void DynamicEx()
        {
            // khai báo tương tự var nhưng với từ khoá dynamic
            // Không cần gán giá trị cho nó
            dynamic testDynamic;
            // Khai báo biến nặc danh
            var student = new

            {
                Ten = "Nguyễn Văn A",
                Tuoi = 19,
                NganhHoc = "Công nghệ thông tin"
            };
            //sử dụng dynamic để gọi phương thức
            inStudentInfo(student.Ten, student.Tuoi, student.NganhHoc);
        }

        private static void inStudentInfo(dynamic ten, dynamic tuoi, dynamic nganhHoc)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"{ten} - {tuoi} tuổi");
            Console.WriteLine($"Học ngành: {nganhHoc}");
            Console.WriteLine("-----------------------");
        }
        // khác với var, dynamic có thể khai báo bên ngoài phương thức
        private dynamic _BienPrivate;
        #endregion

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            DynamicEx();
        }
    }
}
