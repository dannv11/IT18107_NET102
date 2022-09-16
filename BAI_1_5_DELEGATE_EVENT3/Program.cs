using System;

namespace BAI_1_5_DELEGATE_EVENT3
{
    /*
  * Ngoài ra trong C# có sẵn chuẩn tạo ra sẵn sự kiện Delegate
  */
    internal class Program
    {

        class NguoiDung
        {
            public event EventHandler sukienNhapSo;//Tương đương delegate void tendelegate(object sender, EventArgs e);

            public void NhapSo()
            {
                Console.WriteLine("Mời bạn nhập a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                sukienNhapSo.Invoke(this, new NguoiDung1(a, b));
            }
        }

        class NguoiDung1 : EventArgs
        {
            public int a { get; set; }
            public int b { get; set; }

            public NguoiDung1(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }
        class TinhToan
        {
            public void ThiHanh(NguoiDung nd)
            {
                nd.sukienNhapSo += TinhTong;
            }

            private void TinhTong(object sender, EventArgs e)
            {
                NguoiDung1 nd1 = (NguoiDung1)e;
                Console.WriteLine($"{nd1.a} + {nd1.b} = {nd1.a + nd1.b}");
            }
        }
        static void Main(string[] args)
        {
            //PHát đi sự kiện
            NguoiDung nd = new NguoiDung();

            //Nhận sự kiện
            TinhToan tt = new TinhToan();
            tt.ThiHanh(nd);

            //Thực thi
            nd.NhapSo();
        }
    }
}
