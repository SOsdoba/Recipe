using CPUWindowsFormFramework;
using RecipeAppSystem;

namespace RecipeWinForms
{
    public partial class frmRecipeClone : Form
    {
        public frmRecipeClone()
        {
            InitializeComponent();
            BindData();
            btnClone.Click += BtnClone_Click;
        }

        private void BindData()
        {
            WindowsFormsUtility.SetListBinding(cmbRecipeName, DataMaintenance.GetDataList("RecipeList", 0), null, "Recipe");
        }

        private void CloneRecipe()
        {
            int baserecipeid = WindowsFormsUtility.GetIdFromComboBox(cmbRecipeName);
            
            Cursor = Cursors.WaitCursor;
            try
            {
                Recipe.CloneRecipe(baserecipeid);
                int newrecipeid = Recipe.NewRecipeIdGet();
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), newrecipeid);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            CloneRecipe();
        }
    }

}
