using Library.DataAccess;
using Library.Entities;

namespace BookThingsApp
{
    public partial class BookThingsForm : Form
    {
        BookDal _bookDal = new BookDal();
        public BookThingsForm()
        {
            InitializeComponent();
        }



        private void BookThingsApp_Load(object sender, EventArgs e)
        {
            LoadBookList();
        }

        private void LoadBookList()
        {
            dgwBookThings.DataSource = _bookDal.GetAll();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            _bookDal.Add(new Library.Entities.Book
            {

                Kitap_Adi = tbxKitap_Adi.Text,
                Yazar = tbxYazar.Text,
                Yayinevi = tbxYayinevi.Text,
                BasimTarihi = Convert.ToDateTime(tbxBasimTarihi.Text),
                BaskiNo = Convert.ToInt32(tbxBaskiNo.Text),
                Kitap_Adedi = Convert.ToInt32(tbxKitap_Adedi.Text),
                Kitap_SayfaSayisi = Convert.ToInt32(tbxKitap_SayfaSayisi.Text),
                Kitap_Turu = tbxKitap_Turu.Text,

            });
            MessageBox.Show("Kitap eklendi!");
            LoadBookList();
        }

        private void deleteKitapBtn_Click(object sender, EventArgs e)
        {
            int Kitap_Id = Convert.ToInt32(dgwBookThings.CurrentRow.Cells[0].Value);
            _bookDal.Delete(Kitap_Id);
            LoadBookList();
            ClearTextBoxBookThings();
            MessageBox.Show("Kitap silindi!");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearTextBoxBookThings();

        }

        private void ClearTextBoxBookThings()
        {
            tbxKitap_Adi.Text = "";
            tbxYazar.Text = "";
            tbxYayinevi.Text = "";
            tbxBasimTarihi.Text = "";
            tbxBaskiNo.Text = "";
            tbxKitap_Adedi.Text = "";
            tbxKitap_SayfaSayisi.Text = "";
            tbxKitap_Turu.Text = "";
        }

        private void dgwBookThings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxKitap_Adi.Text = dgwBookThings.CurrentRow.Cells[1].Value.ToString();
            tbxYazar.Text = dgwBookThings.CurrentRow.Cells[2].Value.ToString();
            tbxYayinevi.Text = dgwBookThings.CurrentRow.Cells[3].Value.ToString();
            tbxBasimTarihi.Text = dgwBookThings.CurrentRow.Cells[4].Value.ToString();
            tbxBaskiNo.Text = dgwBookThings.CurrentRow.Cells[5].Value.ToString();
            tbxKitap_Adedi.Text = dgwBookThings.CurrentRow.Cells[6].Value.ToString();
            tbxKitap_SayfaSayisi.Text = dgwBookThings.CurrentRow.Cells[7].Value.ToString();
            tbxKitap_Turu.Text = dgwBookThings.CurrentRow.Cells[8].Value.ToString();
        }

        private void updateKitapBtn_Click(object sender, EventArgs e)
        {
            Book book = new Book
            {
                Kitap_Id = Convert.ToInt32(dgwBookThings.CurrentRow.Cells[0].Value),
                Kitap_Adi = tbxKitap_Adi.Text,
                Yazar = tbxYazar.Text,
                Yayinevi = tbxYayinevi.Text,
                BasimTarihi = Convert.ToDateTime(tbxBasimTarihi.Text),
                BaskiNo = Convert.ToInt32(tbxBaskiNo.Text),
                Kitap_Adedi = Convert.ToInt32(tbxKitap_Adedi.Text),
                Kitap_SayfaSayisi = Convert.ToInt32(tbxKitap_SayfaSayisi.Text),
                Kitap_Turu = tbxKitap_Turu.Text,
            };

            _bookDal.Update(book);
            LoadBookList();
            MessageBox.Show("Kitap güncellenmiþtir!");
        }
    }
}