using Library.Core;
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
    public class BookDal
    {

        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Kutuphane;integrated security=true");

        public List<Book> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * From KITAPLAR", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Book> books = new List<Book>();

            while (reader.Read())
            {
                Book book = new Book
                {
                    Kitap_Id = Convert.ToInt32(reader["Kitap_Id"]),
                    Kitap_Adi = (reader["Kitap_Adi"]).ToString(),
                    Yazar = (reader["Yazar"]).ToString(),
                    Yayinevi = (reader["Yayinevi"]).ToString(),
                    BasimTarihi = Convert.ToDateTime(reader["BasimTarihi"]),
                    BaskiNo = Convert.ToInt32(reader["BaskiNo"]),
                    Kitap_Adedi = Convert.ToInt32(reader["Kitap_Adedi"]),
                    Kitap_SayfaSayisi = Convert.ToInt32(reader["Kitap_SayfaSayisi"]),
                    Kitap_Turu = (reader["Kitap_Turu"]).ToString(),



                };
                books.Add(book);
            }

            reader.Close();
            _connection.Close();
            return books;

        }

        public void Add(Book book)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into KITAPLAR(Kitap_Adi,Yazar,Yayinevi,BasimTarihi,BaskiNo,Kitap_Adedi,Kitap_SayfaSayisi,Kitap_Turu) values " +
                "(@Kitap_Adi,@Yazar,@Yayinevi,@BasimTarihi,@BaskiNo,@Kitap_Adedi,@Kitap_SayfaSayisi,@Kitap_Turu)", _connection);


            command.Parameters.AddWithValue("@Kitap_Adi", book.Kitap_Adi);
            command.Parameters.AddWithValue("@Yazar", book.Yazar);
            command.Parameters.AddWithValue("@Yayinevi", book.Yayinevi);
            command.Parameters.AddWithValue("@BasimTarihi", book.BasimTarihi);
            command.Parameters.AddWithValue("@BaskiNo", book.BaskiNo);
            command.Parameters.AddWithValue("@Kitap_Adedi", book.Kitap_Adedi);
            command.Parameters.AddWithValue("@Kitap_SayfaSayisi", book.Kitap_SayfaSayisi);
            command.Parameters.AddWithValue("@Kitap_Turu", book.Kitap_Turu);
            



            command.ExecuteNonQuery();

            _connection.Close();

        }

        public void Update(Book book)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Update KITAPLAR set" +
                " Kitap_Adi=@Kitap_Adi,Yazar=@Yazar,Yayinevi=@Yayinevi,BasimTarihi=@BasimTarihi,BaskiNo=@BaskiNo," +
                "Kitap_Adedi=@Kitap_Adedi,Kitap_SayfaSayisi=@Kitap_SayfaSayisi,Kitap_Turu=@Kitap_Turu where Kitap_Id=@Kitap_Id", _connection);

            command.Parameters.AddWithValue("@Kitap_Id", book.Kitap_Id);
            command.Parameters.AddWithValue("@Kitap_Adi", book.Kitap_Adi);
            command.Parameters.AddWithValue("@Yazar", book.Yazar);
            command.Parameters.AddWithValue("@Yayinevi", book.Yayinevi);
            command.Parameters.AddWithValue("@BasimTarihi", book.BasimTarihi);
            command.Parameters.AddWithValue("@BaskiNo", book.BaskiNo);
            command.Parameters.AddWithValue("@Kitap_Adedi", book.Kitap_Adedi);
            command.Parameters.AddWithValue("@Kitap_SayfaSayisi", book.Kitap_SayfaSayisi);
            command.Parameters.AddWithValue("@Kitap_Turu", book.Kitap_Turu);



            command.ExecuteNonQuery();

            _connection.Close();


        }
        public void UpdateLend(Book book)
        {
            //Book book = new Book();
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Update KITAPLAR set " +
                "Kitap_Adedi=(Kitap_Adedi-@Kitap_Adedi) where Kitap_Id=@Kitap_Id", _connection);

            command.Parameters.AddWithValue("@Kitap_Id", book.Kitap_Id);
            //command.Parameters.AddWithValue("@Kitap_Adi", book.Kitap_Adi);
            //command.Parameters.AddWithValue("@Yazar", book.Yazar);
            //command.Parameters.AddWithValue("@Yayinevi", book.Yayinevi);
            //command.Parameters.AddWithValue("@BasimTarihi", book.BasimTarihi);
            //command.Parameters.AddWithValue("@BaskiNo", book.BaskiNo);
            command.Parameters.AddWithValue("@Kitap_Adedi", book.Kitap_Adedi);
            //command.Parameters.AddWithValue("@Kitap_SayfaSayisi", book.Kitap_SayfaSayisi);
            //command.Parameters.AddWithValue("@Kitap_Turu", book.Kitap_Turu);



            command.ExecuteNonQuery();

            _connection.Close();


        }

        public void Delete(int Kitap_Id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from KITAPLAR where Kitap_Id=@Kitap_Id", _connection);

            command.Parameters.AddWithValue("@Kitap_Id", Kitap_Id);

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

