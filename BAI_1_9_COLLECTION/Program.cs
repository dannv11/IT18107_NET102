using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BAI_1_9_COLLECTION
{
    internal class Program
    {

        #region Phần 1: COLLECTION LÀ GÌ?
        /*
         * ❑Collection là lớp hỗ trợ lưu trữ,
         * quản lý và thao tác với các đối tượng linh hoạt.
           ❑Có thể lưu trữ một tập hợp đối tượng 
        thuộc nhiều kiểu khác nhau.
           ❑Hỗ trợ rất nhiều phương thức để thao 
        tác với tập hợp như: tìm kiếm, sắp xếp, đảo ngược, . . .
           ❑Là một mảng có kích thước động:
               ❖Không cần khai báo kích thước khi khởi tạo.
               ❖Có thể tăng giảm số lượng phần tử 
        trong mảng một cách linh hoạt
         */


        #endregion

        #region Phần 2: Các  Collection thông dụng C#

        /*
         * 1. ArrayList:  Lớp cho phép lưu trữ và quản lý các phần tử giống mảng. Tuy nhiên, không giống như trong mảng, ta có thể thêm hoặc xoá phần tử một cách linh hoạt và có thể tự điều chỉnh kích cỡ một cách tự động.
         * 2. List: List là 1 Generic Collections đưa ra như một sự thay thế ArrayList vì thế về khái niệm cũng như sử dụng nó hoàn toàn giống với ArrayList. 
         * 3. HashTable: Lớp lưu trữ dữ liệu dưới dạng cặp Key – Value. Khi đó ta sẽ truy xuất các phần tử trong danh sách này thông qua Key (thay vì thông qua chỉ số phần tử như mảng bình thường).
         * 4. SortedList: Là sự kêt hợp của ArrayList và HashTable. Tức là dữ liệu sẽ lưu dưới dạng Key – Value. Ta có thể truy xuất các phần tử trong danh sách thông qua Key hoặc thông qua chỉ số phần tử. Đặc biệt là các phần tử trong danh sách này luôn được sắp xếp theo giá trị của Key.
         * 5. Stack:  Lớp cho phép lưu trữ và thao tác dữ liệu theo cấu trúc LIFO (Last In First Out).
         * 6. Queue:   Lớp cho phép lưu trữ và thao tác dữ liệu theo cấu trúc FIFO (First In First Out).
         * 7. BitArray: Lớp cho phép lưu trữ và quản lý một danh sách các bit. Giống mảng các phần tử kiểu bool với true biểu thị cho bit 1 và false biểu thị cho bit 0. Ngoài ra BitArray còn hỗ trợ một số phương thức cho việc tính toán trên bit.  
         */

        #endregion

        
        public static void vidu1()
        {
            // Khai báo collection loại List
            List<string> conVat;
            //// Khởi tạo collection rỗng
            //conVat = new List<string>();
            //// Dùng phương thức add thêm phần tử vào collection
            //conVat.Add("Mèo");
            //conVat.Add("Chó");
            //conVat.Add("Gà");

            // Khởi tạo với một vài phần tử ban đầu
            conVat = new List<string>()
            {
                "Gà",
                "Vịt",
                "Lợn"
            };

            // Xoá 1 phần tử khỏi list
            conVat.Remove("Gà");

            // Duyệt collection
            foreach (string s in conVat)
            {
                Console.WriteLine(s);
            }
        }

        //vidu stack và queue

        public static void vidu2()
        {
            Stack<string> monHoc = new Stack<string>();
            // push thêm phần tử vào stack
            monHoc.Push("Toán");
            monHoc.Push("Ngữ Văn");
            monHoc.Push("Lịch Sử");
            Console.WriteLine("Các phần tử của stack sau khi push");
            foreach(string s in monHoc)
            {
                Console.WriteLine(s);
            }
            // pop phần tử ra khỏi stack
            monHoc.Pop();
            Console.WriteLine("Danh sach phần tử stack sau khi pop");
            foreach (string s in monHoc)
            {
                Console.WriteLine(s);
            }
        }

        #region Phần 3: HashTable  
        /*
         * - Là một Collections lưu trữ dữ liệu dưới dạng cặp Key - Value.
         * - Vì Key và Value đều là kiểu object nên ta có thể lưu trữ được mọi kiểu dữ liệu từ những kiểu cơ sở đến kiểu phức tạp (class).
           
           Một số thuộc tính và phương thức hỗ trợ sẵn trong Hashtable: 
                - Count  Trả về 1 số nguyên là số phần tử hiện có trong Hashtable.           
                - Keys  Trả về 1 danh sách chứa các Key trong Hashtable.           
                - Values  Trả về 1 danh sách chứa các Value trong Hashtable.
                - Add(object Key, object Value)  Thêm 1 cặp Key - Value vào Hashtable.
           
                - Clear()  Xoá tất cả các phần tử trong Hashtable.           
                - Clone()  Tạo 1 bản sao từ Hashtable hiện tại.           
                - ContainsKey(object Key) Kiểm tra đối tượng Key có tồn tại trong Hashtable hay không.           
                - ContainsValue(obj
        ect Value)  Kiểm tra đối tượng Value có tồn tại trong Hashtable hay không.           
                - CopyTo(Array array, int Index)  Thực hiện sao chép tất cả phần tử trong Hashtable sang mảng một chiều array từ vị trí Index của array. Lưu ý: array phải là mảng các object hoặc mảng các DictionaryEntry.           
                - Remove(object Key)  Xoá đối tượng có Key xuất hiện đầu tiên trong Hashtable.
         */
        #endregion

        // vidu3 hashtable
        public static void vidu3()
        {
            // Khai báo và khởi tạo hashtable
            Hashtable diemThi = new Hashtable();
            diemThi.Add("Tung", 8);
            diemThi.Add("Linh", 7);
            diemThi.Add("Dung", 8);

            // truy cập phần tử của Hashtable thông qua key
            Console.WriteLine($"Điểm thi của Tùng Là: {diemThi["Tung"]}");
            // Khi key đã tồn tại thì sẽ báo lỗi
            //diemThi.Add("Linh", 9);
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // vidu1();
            vidu3();
        }
    }
}
