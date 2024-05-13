using CPUWindowsFormFramework;
using RecipeAppSystem;

namespace RecipeWinForms
{
    public partial class frmCookBookClone : Form
    {
        public frmCookBookClone()
        {
            InitializeComponent();
            BindData();
            btnCreate.Click += BtnCreate_Click;
        }

        private void BindData()
        {
            WindowsFormsUtility.SetListBinding(optUserName, DataMaintenance.GetDataList("Users", 1), null, "Users");
        }

        private void CreateCookBook()
        {
            int usersid = WindowsFormsUtility.GetIdFromComboBox(optUserName);
            
            Cursor = Cursors.WaitCursor;
            try
            {
                CookBooks.CloneCookBook(usersid);
                int newcookbookid = CookBooks.NewCookBookIdGet();
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookBook), newcookbookid);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            CreateCookBook();
        }

    }
}
