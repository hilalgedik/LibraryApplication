using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{

    public class MemberDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Kutuphane;integrated security=true");
        
        //Member Get(Expression<Func<Member, bool>> filter);
        public List<Member> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * From UYELER", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Member> members = new List<Member>();

            while (reader.Read())
            {
                Member member = new Member
                {
                    Uye_Id = Convert.ToInt32(reader["Uye_Id"]),
                    Uye_Isim = (reader["Uye_Isim"]).ToString(),
                    Uye_Soyisim = (reader["Uye_Soyisim"]).ToString(),
                    //Uye_No = (reader["Uye_No"]).ToString(),
                    Uye_Yas = Convert.ToInt32(reader["Uye_Yas"]),
                    Uye_Meslek = (reader["Uye_Meslek"]).ToString(),
                    Uye_Adres = (reader["Uye_Adres"]).ToString(),
                    UyelikTarihi = Convert.ToDateTime(reader["UyelikTarihi"]),
                    SonKitapAlmaTarihi = Convert.ToDateTime(reader["SonKitapAlmaTarihi"]),
                    Uye_Mail = (reader["Uye_Mail"]).ToString(),
                    Uye_TelNo = (reader["Uye_TelNo"]).ToString(),
                    OkuduguKitapSayisi = Convert.ToInt32(reader["OkuduguKitapSayisi"]),
                    //Fotograf = Convert.ToByte(reader["Fotograf"]),


                };
                members.Add(member);
            }

            reader.Close();
            _connection.Close();
            return members;

        }


        public void Add(Member member)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into UYELER(Uye_Isim,Uye_Soyisim,Uye_Yas,Uye_Meslek,Uye_Adres,UyelikTarihi,SonKitapAlmaTarihi,Uye_Mail,Uye_TelNo,OkuduguKitapSayisi) values " +
                "(@Uye_Isim,@Uye_Soyisim,@Uye_Yas,@Uye_Meslek,@Uye_Adres,@UyelikTarihi,@SonKitapAlmaTarihi,@Uye_Mail,@Uye_TelNo,@OkuduguKitapSayisi)", _connection);

            
            command.Parameters.AddWithValue("@Uye_Isim", member.Uye_Isim);
            command.Parameters.AddWithValue("@Uye_Soyisim", member.Uye_Soyisim);
            //command.Parameters.AddWithValue("@Uye_No", member.Uye_No);
            command.Parameters.AddWithValue("@Uye_Yas", member.Uye_Yas);
            command.Parameters.AddWithValue("@Uye_Meslek", member.Uye_Meslek);
            command.Parameters.AddWithValue("@Uye_Adres", member.Uye_Adres);
            command.Parameters.AddWithValue("@UyelikTarihi", member.UyelikTarihi);
            command.Parameters.AddWithValue("@SonKitapAlmaTarihi", member.SonKitapAlmaTarihi);
            command.Parameters.AddWithValue("@Uye_Mail", member.Uye_Mail);
            command.Parameters.AddWithValue("@Uye_TelNo", member.Uye_TelNo);
            command.Parameters.AddWithValue("@OkuduguKitapSayisi", member.OkuduguKitapSayisi);



            command.ExecuteNonQuery();

            _connection.Close();

        }

        public void Update(Member member)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Update UYELER set" +
                " Uye_Isim=@Uye_Isim,Uye_Soyisim=@Uye_Soyisim,Uye_Yas=@Uye_Yas,Uye_Meslek=@Uye_Meslek,Uye_Adres=@Uye_Adres," +
                "UyelikTarihi=@UyelikTarihi,SonKitapAlmaTarihi=@SonKitapAlmaTarihi,Uye_Mail=@Uye_Mail,Uye_TelNo=@Uye_TelNo,OkuduguKitapSayisi=@OkuduguKitapSayisi" +
                " where Uye_Id=@Uye_Id", _connection);

            command.Parameters.AddWithValue("@Uye_Id", member.Uye_Id);
            command.Parameters.AddWithValue("@Uye_Isim", member.Uye_Isim);
            command.Parameters.AddWithValue("@Uye_Soyisim", member.Uye_Soyisim);
            //command.Parameters.AddWithValue("@Uye_No", member.Uye_No);
            command.Parameters.AddWithValue("@Uye_Yas", member.Uye_Yas);
            command.Parameters.AddWithValue("@Uye_Meslek", member.Uye_Meslek);
            command.Parameters.AddWithValue("@Uye_Adres", member.Uye_Adres);
            command.Parameters.AddWithValue("@UyelikTarihi", member.UyelikTarihi);
            command.Parameters.AddWithValue("@SonKitapAlmaTarihi", member.SonKitapAlmaTarihi);
            command.Parameters.AddWithValue("@Uye_Mail", member.Uye_Mail);
            command.Parameters.AddWithValue("@Uye_TelNo", member.Uye_TelNo);
            command.Parameters.AddWithValue("@OkuduguKitapSayisi", member.OkuduguKitapSayisi);
            command.ExecuteNonQuery();

            _connection.Close();


        }

        public void Delete(int Uye_Id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from UYELER where Uye_Id=@Uye_Id", _connection);

            command.Parameters.AddWithValue("@Uye_Id", Uye_Id);
            
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
