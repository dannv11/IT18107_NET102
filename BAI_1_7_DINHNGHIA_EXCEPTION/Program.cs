using System;
using System.Text;

namespace BAI_1_6_EXCEPTION
{
    internal class Program
    {
        // VIDU VE THROW
        public static void checkTuoi(int tuoi)
        {
            if(tuoi < 18)
            {
                throw new Exception("Ban chua du tuoi dk ket hon");
            }
            Console.WriteLine("Chuc mung ban da du tuoi ket hon");
        }
        public static void Main(string[] args)
        {
            int tuoi = 10;
            try
            {
                checkTuoi(tuoi);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
