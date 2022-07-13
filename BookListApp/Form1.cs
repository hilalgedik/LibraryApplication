using Library.DataAccess;

namespace BookListApp
{
    public partial class BookListForm : Form
    {
        public BookListForm()
        {
            InitializeComponent();
        }
        BookDal _bookDal = new BookDal();
        private void listBookBtn_Click(object sender, EventArgs e)
        {
            dgwBooks.DataSource = _bookDal.GetAll();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}