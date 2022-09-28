using System;

namespace BAI_2_7_BIEU_THUC_LAMBDA
{
    internal class Program
    {
        #region LAMBDA
        //Biểu thức lambda hay biểu thức Anonymous
        //nó là một cái phương thức nhưng không có tên
        // Cú pháp khai báo sử dụng toán tử =>
        //Cú pháp 1:
        //(tham số)=> Biểu thức;
        //Cú pháp 2:
        //    (tham số)=>{
        //    Các biểu thức hoặc return .....
        //    }
        #endregion  

        // sử dụng delegate với biểu thức lambda
        public delegate int TinhHieu(int x, int y);

        public static void vidu1()
        {
            int x = 10, y = 5;
            TinhHieu tinhHieu = (int x, int y) => { return x - y; };
            TinhHieu tinhHieu2 = (int x, int y) => x - y;
            Console.WriteLine($"{x} - {y} = {tinhHieu2(x,y)}");
        }
        //vi du 2: Khai báo phương thức bằng biểu thức lambda
        static double tinhThuong(int x, int y) => x / y;

        // ví dụ 3: sử dụng biểu thức lambda

        static void Vidu3()
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };

            // cách 1 dùng delegate
            Array.ForEach(a, delegate (int x)
            {
                Console.WriteLine(x);
            });

            // Cách 2
            Array.ForEach(a, x => Console.WriteLine(x));

            //cách 3 
            foreach(var x in a)
            {
                Console.WriteLine(x);
            }    
        }

        #region một số nguyên tắc khi sử dụng lambda
        delegate void ChaoBan(string a);
        delegate void ChaoBan2();
        delegate void ChaoBan3(string a, string b);

        delegate int Tinh(int a, int b);

        static void vidu3()
        {
            //Không quan tâm đến kiểu dữ liệu đầu vào

            ChaoBan chaoBan1 = (string a) => { Console.WriteLine(a); };

            //Nếu chỉ có 1 câu lệnh thì bỏ {}
            ChaoBan chaoBan2 = (a) => Console.WriteLine(a);
            // Nếu không có tham số thì để trống ()
            ChaoBan2 chao = () => Console.WriteLine("something");
            // Nếu có nhiều tham số thì ngăn cách bằng dấu ,
            ChaoBan3 chao33 = (x, y) => Console.WriteLine("something");

            // Nếu chỉ có 1 tham số thì bỏ ()

            ChaoBan chaoBan = temp => Console.WriteLine(temp);
            // return
            Tinh tinh = (x, y) => { return x + y; };

        }
        #endregion

        static void Main(string[] args)
        {
            vidu1();
        }
    }
}
