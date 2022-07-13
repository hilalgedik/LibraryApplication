using Library.DataAccess;

namespace MemberListApp
{
    public partial class MemberListForm : Form
    {
        public MemberListForm()
        {
            InitializeComponent();
        }
        MemberDal _memberDal = new MemberDal();
        private void listMemberBtn_Click(object sender, EventArgs e)
        {
            dgwMembers.DataSource = _memberDal.GetAll();
        }

        private void MemberListForm_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}