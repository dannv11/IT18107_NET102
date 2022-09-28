using System;

namespace BAI_2_1_GENERIC_CLASS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai Báo class generic kiểu Int
            ClassGeneric<int> intGeneric;
            // Khai Báo class generic kiểu string
            ClassGeneric<string> stringGeneric;
            stringGeneric= new ClassGeneric<string>(5);
            stringGeneric.addItemElement(2, "Mèo");
            stringGeneric.addItemElement(1, "Chim");

            Console.WriteLine($"Phan tu thu 0 = {stringGeneric.getItemElement(0)}");
            Console.WriteLine($"Phan tu thu 1 = {stringGeneric.getItemElement(1)}");

        }
    }
}
