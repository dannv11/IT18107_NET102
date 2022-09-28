using System;
using System.Collections.Generic;
using System.Text;

namespace BAI_2_6_DOC_GHI_FILE
{
    [Serializable]
    internal class Vaccine
    {
        private string _maVaccine;
        private string _tenVaccine;
        private bool _status;

        public Vaccine()
        {
        }

        public Vaccine(string maVaccine, string tenVaccine, bool status)
        {
            _maVaccine = maVaccine;
            _tenVaccine = tenVaccine;
            _status = status;
        }
        public string MaVaccine
        {
            get => _maVaccine;
            set => _maVaccine = value;

        }
        public string TenVaccine
        {
            get => _tenVaccine;
            set => _tenVaccine = value;
        }
        public bool Status
        {
            get => _status;
            set => _status = value;
        }
        public void printToConsole()
        {
            Console.WriteLine($"Mã Vacxin:  {_maVaccine}  Tên Vacxin:  {_tenVaccine}  Trạng thái:  {(_status?"Hoạt động":"Không hoạt động")}");
        }
    }
}
