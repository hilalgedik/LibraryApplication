using Library.DataAccess;
using Library.Entities;

namespace LendABookApp
{
    public partial class LendABookForm : Form
    {
        public LendABookForm()
        {
            InitializeComponent();
        }

        LendedBookDal _lendedBookDal = new LendedBookDal();
        private void LoadLendedBook()
        {
            dgwLendedBookList.DataSource = _lendedBookDal.GetAll();
        }

        MemberDal _memberDal = new MemberDal();
        private void LoadMember()
        {
            dgwMemberList.DataSource = _memberDal.GetAll();
        }
        BookDal _bookDal = new BookDal();
        private void LoadBook()
        {
            dgwBookList.DataSource=_bookDal.GetAll();
        }
        private void LendABookForm_Load(object sender, EventArgs e)
        {
            LoadLendedBook();
            LoadMember();
            LoadBook();

        }

        private void dgwBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxKitap_Id.Text = dgwBookList.CurrentRow.Cells[0].Value.ToString();
            tbxKitap_Adi.Text = dgwBookList.CurrentRow.Cells[1].Value.ToString();
            tbxKitap_IdLended.Text= dgwBookList.CurrentRow.Cells[0].Value.ToString();
            tbxKitap_AdiLended.Text=dgwBookList.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgwMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUye_Id.Text = dgwMemberList.CurrentRow.Cells[0].Value.ToString();
            tbxUye_Isim.Text = dgwMemberList.CurrentRow.Cells[1].Value.ToString();
            tbxUye_Soyisim.Text = dgwMemberList.CurrentRow.Cells[2].Value.ToString();
            tbxUye_TelNo.Text = dgwMemberList.CurrentRow.Cells[10].Value.ToString();

            tbxUye_IdLended.Text = dgwMemberList.CurrentRow.Cells[0].Value.ToString();
            tbxUye_IsimLended.Text = dgwMemberList.CurrentRow.Cells[1].Value.ToString();
            tbxUye_SoyisimLended.Text = dgwMemberList.CurrentRow.Cells[2].Value.ToString();
            tbxUye_TelNoLended.Text = dgwMemberList.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnLended_Click(object sender, EventArgs e)
        {
            _lendedBookDal.Add(new LendedBook
            {
                Kitap_Id = Convert.ToInt32(tbxKitap_IdLended.Text),
                Uye_Id=Convert.ToInt32(tbxUye_IdLended.Text),
                Kitap_Adi=tbxKitap_AdiLended.Text,
                Uye_Isim=tbxUye_IsimLended.Text,
                Uye_Soyisim = tbxUye_SoyisimLended.Text,
                Uye_TelNo = tbxUye_TelNoLended.Text,
                Kitap_Adedi=Convert.ToInt32(tbxKitap_AdediLended.Text),

            });


            _bookDal.UpdateLend(new Book
            {
                Kitap_Id = Convert.ToInt32(dgwBookList.CurrentRow.Cells[0].Value),
                Kitap_Adedi = Convert.ToInt32(tbxKitap_AdediLended.Text),

            });
            MessageBox.Show("Kitap ödünç verildi!");
            LoadLendedBook();
            LoadBook();

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbxKitap_IdLended.Text = "";
            tbxUye_IdLended.Text = "";
            tbxKitap_AdiLended.Text = "";
            tbxUye_IsimLended.Text = "";
            tbxUye_SoyisimLended.Text = "";
            tbxUye_TelNoLended.Text = "";
            tbxKitap_AdediLended.Text = "";


        }

        private void btnCleanMember_Click(object sender, EventArgs e)
        {
            tbxUye_Id.Text = "";
            tbxUye_Isim.Text = "";
            tbxUye_Soyisim.Text = "";
            tbxUye_TelNo.Text = "";
        }

        private void btnCleanBook_Click(object sender, EventArgs e)
        {
            tbxKitap_Id.Text = "";
            tbxKitap_Adi.Text = "";

        }

       
    }
}