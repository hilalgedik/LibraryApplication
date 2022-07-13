
using Library.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Book:IEntity
    {
        public int Kitap_Id { get; set; }
        public string Kitap_Adi { get; set; }
        public string Yazar { get; set; }
        public string Yayinevi { get; set; }
        public DateTime BasimTarihi { get; set; }
        public int BaskiNo { get; set; }
        public int Kitap_Adedi { get; set; }
        public int Kitap_SayfaSayisi { get; set; }
        public string Kitap_Turu { get; set; }
    }
}
