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
    public class LendedBookDal
    {

        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Kutuphane;integrated security=true");

        public List<LendedBook> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * From ODUNC_KİTAP_LİSTESİ", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<LendedBook> lendedBooks = new List<LendedBook>();
            if (lendedBooks != null)
            {
                while (reader.Read())
                {
                    LendedBook lendedBook = new LendedBook
                    {
                        OduncKitapId = Convert.ToInt32(reader["OduncKitapId"]),
                        Kitap_Id = Convert.ToInt32(reader["Kitap_Id"]),
                        Uye_Id = Convert.ToInt32(reader["Uye_Id"]),
                        Kitap_Adi = (reader["Kitap_Adi"]).ToString(),
                        Uye_Isim = (reader["Uye_Isim"]).ToString(),
                        Uye_Soyisim = (reader["Uye_Soyisim"]).ToString(),
                        Uye_TelNo = (reader["Uye_TelNo"]).ToString(),
                        Kitap_Adedi = Convert.ToInt32(reader["Kitap_Adedi"]),


                    };
                    lendedBooks.Add(lendedBook);
                }
            }
            else
            {
                reader.Close();
            }

            reader.Close();
            _connection.Close();
            return lendedBooks;

        }


        public void Add(LendedBook lendedBook)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into ODUNC_KİTAP_LİSTESİ(Kitap_Id,Uye_Id,Kitap_Adi,Uye_Isim,Uye_Soyisim,Uye_TelNo,Kitap_Adedi) values " +
                "(@Kitap_Id,@Uye_Id,@Kitap_Adi,@Uye_Isim,@Uye_Soyisim,@Uye_TelNo,@Kitap_Adedi)", _connection);

            command.Parameters.AddWithValue("@Kitap_Id", lendedBook.Kitap_Id);
            command.Parameters.AddWithValue("@Uye_Id", lendedBook.Uye_Id);
            command.Parameters.AddWithValue("@Kitap_Adi", lendedBook.Kitap_Adi);
            command.Parameters.AddWithValue("@Uye_Isim", lendedBook.Uye_Isim);
            command.Parameters.AddWithValue("@Uye_Soyisim", lendedBook.Uye_Soyisim);
            command.Parameters.AddWithValue("@Uye_TelNo", lendedBook.Uye_TelNo);
            command.Parameters.AddWithValue("@Kitap_Adedi", lendedBook.Kitap_Adedi);


            command.ExecuteNonQuery();

            _connection.Close();

        }

        

        public void Delete(int OduncKitapId)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from ODUNC_KİTAP_LİSTESİ where OduncKitapId=@OduncKitapId", _connection);

            command.Parameters.AddWithValue("@OduncKitapId", OduncKitapId);

            command.ExecuteNonQuery();

            _connection.Close();


        }



        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
    }
}
