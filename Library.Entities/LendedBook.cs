using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class LendedBook
    {
        public int OduncKitapId { get; set; }
        public int Kitap_Id { get; set; }
        public int Uye_Id { get; set; }
        public string Kitap_Adi { get; set; }
        public string Uye_Isim { get; set; }
        public string Uye_Soyisim { get; set; }
        public string Uye_TelNo { get; set; }
        public int Kitap_Adedi { get; set; }
    }
}
