using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class TakeBackBookDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Kutuphane;integrated security=true");
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public void UpdateTakeBack(Book book)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Update KITAPLAR set " +
                "Kitap_Adedi=(Kitap_Adedi+@Kitap_Adedi) where Kitap_Id=@Kitap_Id", _connection);

            command.Parameters.AddWithValue("@Kitap_Id", book.Kitap_Id);
            //command.Parameters.AddWithValue("@Kitap_Adi", book.Kitap_Adi);
           // command.Parameters.AddWithValue("@Yazar", book.Yazar);
           // command.Parameters.AddWithValue("@Yayinevi", book.Yayinevi);
            //command.Parameters.AddWithValue("@BasimTarihi", book.BasimTarihi);
            //command.Parameters.AddWithValue("@BaskiNo", book.BaskiNo);
            command.Parameters.AddWithValue("@Kitap_Adedi", book.Kitap_Adedi);
            //command.Parameters.AddWithValue("@Kitap_SayfaSayisi", book.Kitap_SayfaSayisi);
            //command.Parameters.AddWithValue("@Kitap_Turu", book.Kitap_Turu);



            command.ExecuteNonQuery();

            _connection.Close();


        }

    }
}
