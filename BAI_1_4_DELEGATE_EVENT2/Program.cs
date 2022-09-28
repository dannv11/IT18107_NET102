using System;

namespace BAI_1_4_DELEGATE_EVENT2
{
    internal class Program
    {
        public delegate void SuKienNhap2So(int x, int y);

        class NguoiDung
        {
            public event SuKienNhap2So sukienNhapSo;

            public void NhapSo()
            {
                Console.WriteLine("Mời bạn nhập a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                sukienNhapSo.Invoke(a, b);
            }
        }

        class TinhToan
        {
            public void ThiHanh(NguoiDung nd)
            {
                nd.sukienNhapSo += TinhTong;
            }

            private void TinhTong(int x, int y)
            {
                Console.WriteLine($"{x} + {y} = {x + y}");
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
