using Library.DataAccess;
using Library.Entities;

namespace MemberThingsApp1
{
    public partial class memberThingsForm : Form
    {
        public memberThingsForm()
        {
            InitializeComponent();
        }

        MemberDal _memberDal = new MemberDal();
        private void LoadProduct()
        {
            dgwMemberThings.DataSource = _memberDal.GetAll();
        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            _memberDal.Add(new Library.Entities.Member
            {
                Uye_Isim = tbxUye_Isim.Text,
                Uye_Soyisim = tbxUye_Soyisim.Text,
                //Uye_No = tbxUye_No.Text,
                Uye_Yas = Convert.ToInt32(tbxUye_Yas.Text),
                Uye_Meslek = tbxUye_Meslek.Text,
                Uye_Adres = tbxUye_Adres.Text,
                UyelikTarihi = Convert.ToDateTime(tbxUyelikTarihi.Text),
                SonKitapAlmaTarihi = Convert.ToDateTime(tbxSonKitapAlmaTarihi.Text),
                Uye_Mail = tbxUye_Mail.Text,
                Uye_TelNo=tbxUye_TelNo.Text,
                OkuduguKitapSayisi=Convert.ToInt32(tbxOkuduguKitapSayisi.Text),

            });
            MessageBox.Show("Üye eklendi!");
            LoadProduct();
        }

        private void memberThingsForm_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            tbxUye_Isim.Text = "";
            tbxUye_Soyisim.Text = "";
            //tbxUye_No.Text = "";
            tbxUye_Yas.Text = "";
            tbxUye_Meslek.Text = "";
            tbxUye_Adres.Text = "";
            tbxUyelikTarihi.Text = "";
            tbxSonKitapAlmaTarihi.Text = "";
            tbxUye_Mail.Text = "";
            tbxUye_TelNo.Text = "";
            tbxOkuduguKitapSayisi.Text = "";

        }

        private void dgwMemberThings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUye_Isim.Text = dgwMemberThings.CurrentRow.Cells[1].Value.ToString();
            tbxUye_Soyisim.Text = dgwMemberThings.CurrentRow.Cells[2].Value.ToString();
            //tbxUye_No.Text = dgwMemberThings.CurrentRow.Cells[3].Value.ToString();
            tbxUye_Yas.Text = dgwMemberThings.CurrentRow.Cells[4].Value.ToString();
            tbxUye_Meslek.Text = dgwMemberThings.CurrentRow.Cells[5].Value.ToString();
            tbxUye_Adres.Text = dgwMemberThings.CurrentRow.Cells[6].Value.ToString();
            tbxUyelikTarihi.Text = dgwMemberThings.CurrentRow.Cells[7].Value.ToString();
            tbxSonKitapAlmaTarihi.Text = dgwMemberThings.CurrentRow.Cells[8].Value.ToString();
            tbxUye_Mail.Text = dgwMemberThings.CurrentRow.Cells[9].Value.ToString();
            tbxUye_TelNo.Text = dgwMemberThings.CurrentRow.Cells[10].Value.ToString();
            tbxOkuduguKitapSayisi.Text = dgwMemberThings.CurrentRow.Cells[11].Value.ToString();


        }

        private void updateMemberBtn_Click(object sender, EventArgs e)
        {

            Member member = new Member
            {
                Uye_Id = Convert.ToInt32(dgwMemberThings.CurrentRow.Cells[0].Value),
                Uye_Isim = tbxUye_Isim.Text,
                Uye_Soyisim = tbxUye_Soyisim.Text,
                //Uye_No = tbxUye_No.Text,
                Uye_Yas = Convert.ToInt32(tbxUye_Yas.Text),
                Uye_Meslek = tbxUye_Meslek.Text,
                Uye_Adres = tbxUye_Adres.Text,
                UyelikTarihi = Convert.ToDateTime(tbxUyelikTarihi.Text),
                SonKitapAlmaTarihi = Convert.ToDateTime(tbxSonKitapAlmaTarihi.Text),
                Uye_Mail = tbxUye_Mail.Text,
                Uye_TelNo = tbxUye_TelNo.Text,
                OkuduguKitapSayisi = Convert.ToInt32(tbxOkuduguKitapSayisi.Text),
            };

            _memberDal.Update(member);
            LoadProduct();
            MessageBox.Show("Üye güncellenmiþtir!");
        }

        private void deleteMemberBtn_Click(object sender, EventArgs e)
        {
            int Uye_Id = Convert.ToInt32(dgwMemberThings.CurrentRow.Cells[0].Value);
            _memberDal.Delete(Uye_Id);
            LoadProduct();
            MessageBox.Show("Üye silindi!");
        }
    }
}