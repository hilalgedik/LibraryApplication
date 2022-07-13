using BookListApp;
using BookThingsApp;
using LendABookApp;
using MemberListApp;
using MemberThingsApp1;
using TakeBackBookApp;

namespace LibraryMainMenu
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void getMemberListBtn_Click(object sender, EventArgs e)
        {
            MemberListForm memberListForm = new MemberListForm();
            memberListForm.Show();
        }

        private void bookListBtn_Click(object sender, EventArgs e)
        {
            BookListForm bookListForm = new BookListForm();
            bookListForm.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void MemberThingsBtn_Click(object sender, EventArgs e)
        {
            memberThingsForm memberThingsForm1 = new memberThingsForm();
            memberThingsForm1.Show();
        }

        private void lendABookBtn_Click(object sender, EventArgs e)
        {
            LendABookForm lendABookForm = new LendABookForm();
            lendABookForm.Show();
        }

        private void BookThingsBtn_Click(object sender, EventArgs e)
        {
            BookThingsForm bookThingsForm = new BookThingsForm();
            bookThingsForm.Show();
               
        }

       

        private void takeBackBookBtn_Click(object sender, EventArgs e)
        {
            TakeBackBookForm takeBackBookForm = new TakeBackBookForm();
            takeBackBookForm.Show();
        }
    }
}