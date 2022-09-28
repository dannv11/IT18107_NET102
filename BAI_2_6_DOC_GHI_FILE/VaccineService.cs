using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace BAI_2_6_DOC_GHI_FILE
{
    internal class VaccineService
    {
        private FileStream _fileStream;
        private BinaryFormatter _binaryFormatter;

        public void writeToFile(string path,List<Vaccine> vaccines)
        {
            _fileStream = new FileStream(path,FileMode.Create);
            _binaryFormatter = new BinaryFormatter();
            _binaryFormatter.Serialize(_fileStream, vaccines);
            // Serialize là phương thức chuyển hoá dạng đối tượng sang
            // dạng text hoặc mảng,... mà có thể lưu vào file
            _fileStream.Close();
        }

        public List<Vaccine> readFromFile(string path)
        {
            _fileStream = new FileStream(path, FileMode.Open);
            _binaryFormatter = new BinaryFormatter();
            var data = _binaryFormatter.Deserialize(_fileStream);
            var result = new List<Vaccine>();
            result = (List<Vaccine>)data;
            _fileStream.Close();
            return result;
        }
    }
}
