using Library.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Member:IEntity
    {
        public int Uye_Id { get; set; }
        public string Uye_Isim { get; set; }
        public string Uye_Soyisim { get; set; }
        public string Uye_No { get; set; }
        public int Uye_Yas { get; set; }
        public string Uye_Meslek { get; set; }
        public string Uye_Adres { get; set; }
        public DateTime UyelikTarihi { get; set; }
        public DateTime SonKitapAlmaTarihi { get; set; }
        public string Uye_Mail { get; set; }
        public string Uye_TelNo { get; set; }
        public int OkuduguKitapSayisi { get; set; }
        //public byte Fotograf { get; set; }
    }
}
