using CPUWindowsFormFramework;
using RecipeAppSystem;
using System.Data;
using System.Diagnostics;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        public void ShowForm(int recipeid)
        {
            dtrecipe = Recipe.Load(recipeid);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtcuisinetype = Recipe.GetCuisineList();
            DataTable dtusers = Recipe.GetUsersList();

            WindowsFormsUtility.SetListBinding(lstUserName, dtusers, dtrecipe, "Users");
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtcuisinetype, dtrecipe, "CuisineType");
            WindowsFormsUtility.SetControlBindings(txtRecipeName, dtrecipe);
            WindowsFormsUtility.SetControlBindings(txtCalories, dtrecipe);
            WindowsFormsUtility.SetControlBindings(txtDraftDate, dtrecipe);
            WindowsFormsUtility.SetControlBindings(txtPublishDate, dtrecipe);
            WindowsFormsUtility.SetControlBindings(txtArchiveDate, dtrecipe);
            WindowsFormsUtility.SetControlBindings(txtRecipeStatus, dtrecipe);
            this.Show();
        }

        private void Save()
        {
            //DataRow r = dtrecipe.Rows[0];
            // string draftdate = txtDraftDate.Text;// != "" ? "'" + r["DraftDate"] + "'" : "'" + DateTime.Now.ToString() + "'";
            // string publishdate = txtPublishDate.Text;// != "" ? "'" + r["PublishDate"] + "'" : "null";
            // string archivedate = txtArchiveDate.Text; //!= "" ? "'" + r["ArchiveDate"] + "'" : "null";
            Recipe.Save(dtrecipe);
        }

        private void Delete()
        {
            Recipe.Delete(dtrecipe);
            this.Close();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
