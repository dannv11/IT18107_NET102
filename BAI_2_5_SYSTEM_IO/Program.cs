using System;
using System.IO;
using System.Text;

namespace BAI_2_5_SYSTEM_IO
{
    internal class Program
    {
        #region Phần 1: THAO TÁC VỚI TẬP TIN VÀ THƯ MỤC
        /*
         * 1. SYSTEM.IO NAMESPACE
         *      + ❑System.IO Namespace có các lớp khác nhau được sử dụng để thực hiện nhiều hoạt động với các tập tin, chẳng hạn như việc tạo và xóa các tập tin, đọc hoặc viết vào một tập tin, đóng một tập tin.
                + ❑Một tập tin là một tập hợp các dữ liệu được lưu trữ trong một đĩa với một tên cụ thể và một đường dẫn thư mục. Khi một tập tin được mở để đọc hoặc viết, nó sẽ trở thành một luồng tin.
           2.System.IO namespace có nhiều lớp đa dạng mà được sử dụng để thực hiện các hoạt động khác nhau với File, như tạo và xóa file, đọc và ghi một File, đóng một File, …    
                + Bảng sau hiển thị một số lớp non-abstract được sử dụng phổ biến trong System.IO namespace trong C#:
                       - BinaryReader	Đọc dữ liệu gốc (primitive data) từ một binary stream
                       - BinaryWriter	Ghi dữ liệu gốc trong định dạng nhị phân
                       - BufferedStream	Một nơi lưu giữ tạm thời cho một stream
                       - Directory	Giúp ích trong việc thao tác một cấu trúc thư mục
                       - DirectoryInfo	Được sử dụng để thực hiện các hoạt động trên các thư mục
                       - DriveInfo	Cung cấp thông tin cho các Drive
                       - File	Giúp ích trong việc thao tác các File
                       - FileInfo	Được sử dụng để thực hiện các hoạt động trên các File
                       - FileStream	Được sử dụng để đọc và ghi bất kỳ vị trí nào trong một File
                       - MemoryStream	Được sử dụng để truy cập ngẫu nhiên tới stream được lưu giữ trong bộ nhớ
                       - Path	Thực hiện các hoạt động trên thông tin path
                       - StreamReader	Được sử dụng để đọc các ký tự từ một stream
                       - StreamWriter	Được sử dụng để ghi các ký tự tới một stream
                       - StringReader	Được sử dụng để đọc từ một string buffer
                       - StringWriter	Được sử dụng để ghi vào một string buffer  
         */


        #endregion

        #region DiskPartition & DirectoryInfo
        public static void DiskPartition()
        {
            do
            {
                DriveInfo[] driveInfos = DriveInfo.GetDrives();
                Console.WriteLine("Tất cả phân vùng trên máy:");
                Console.WriteLine("--------------------------");
                foreach(var item in driveInfos)
                {
                    Console.WriteLine(item.Name);
                }
                Console.WriteLine("Lựa chọn phân vùng:");
                string ch = Console.ReadLine();
                var driverInfo = new DriveInfo(ch);
                Console.WriteLine($"\nDriver name: {driverInfo.Name}");
                Console.WriteLine($"\nDriver Size: {driverInfo.TotalSize}");
                Console.WriteLine($"\nDriver FreeSpace: {driverInfo.TotalFreeSpace}");
                Console.WriteLine($"\nDriver type: {driverInfo.DriveType}");
            } while (true);
        }
        public static void directoryInfo()
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\fpoly");
            di.Create();

            DirectoryInfo di2 = new DirectoryInfo(@"D:\fpoly");
            di.CreateSubdirectory(@"txt");

            // Xoá Thư mục
            Directory.Delete(@"D:\fpoly",true);


        }
        #endregion

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            directoryInfo();
        }
    }
}
