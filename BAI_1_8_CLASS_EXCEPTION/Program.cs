using BAI_1_8_CLASS_EXCEPTION;
using System;
using System.Text;

namespace BAI_1_6_EXCEPTION
{
    internal class Program
    {
        // VIDU VE THROW
        public static void checkTruong(string name)
        {
            if(name != "Fpoly")
            {
                throw new CheckTruongException("Ban da khong dang ky truong Fpoly");
            }
        }
        public static void checkTuoi(int tuoi)
        {
            if (tuoi < 18)
            {
                throw new CheckTuoiException("");
            }
            Console.WriteLine("Chuc mung ban da du tuoi ket hon");
        }
        public static void Main(string[] args)
        {
            int tuoi = 10;
            string tenTruong = "Haui";
            try
            {
                checkTuoi(tuoi);
                checkTruong(tenTruong);
            }
            catch (CheckTruongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(CheckTuoiException ex)
            {
                ex.ThongBaoLoi();
            }
        }
    }
}
