using Library.DataAccess;
using Library.Entities;

namespace TakeBackBookApp
{
    public partial class TakeBackBookForm : Form
    {
        public TakeBackBookForm()
        {
            InitializeComponent();
        }
        LendedBookDal _lendedBookDal = new LendedBookDal();
        BookDal _bookDal = new BookDal();
        TakeBackBookDal _takeBackBookDal = new TakeBackBookDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLendedBookList();
            LoadBookList();
        }

        private void LoadBookList()
        {
            dgwBookList.DataSource = _bookDal.GetAll();
        }

        private void LoadLendedBookList()
        {
            dgwLendedBookList.DataSource = _lendedBookDal.GetAll();
        }

        private void dgwLendedBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxKitap_Id.Text = dgwLendedBookList.CurrentRow.Cells[1].Value.ToString();
            tbxKitap_Adi.Text = dgwLendedBookList.CurrentRow.Cells[3].Value.ToString();
            tbxKitap_Adedi.Text = dgwLendedBookList.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnTakeBackBook_Click(object sender, EventArgs e)
        {
            _takeBackBookDal.UpdateTakeBack(new Book
            {
                Kitap_Id = Convert.ToInt32(tbxKitap_Id.Text),
                Kitap_Adedi = Convert.ToInt32(tbxKitap_Adedi.Text),

            });
            int OduncKitapId = Convert.ToInt32(dgwLendedBookList.CurrentRow.Cells[0].Value.ToString());
            _lendedBookDal.Delete(OduncKitapId);
            LoadLendedBookList();
            LoadBookList();
            MessageBox.Show("Kitap teslim alýndý!");
        }
    }
}