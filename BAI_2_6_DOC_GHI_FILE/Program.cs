using System;
using System.Collections.Generic;
using System.Text;

namespace BAI_2_6_DOC_GHI_FILE
{
    internal class Program
    {
        private static string _path = @"D:\data1";
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            VaccineService service = new VaccineService();
            var data = new List<Vaccine>
            { 
                new Vaccine("1","Mordena",true),
                new Vaccine("2","Astra Zeneca",true),
                new Vaccine("3","Pfizer",true)
            };
            service.writeToFile(_path, data);
            var readData = service.readFromFile(_path);
            Console.WriteLine("----------------------");
            readData.ForEach(x => x.printToConsole());
        }
    }
}
