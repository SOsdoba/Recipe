using CPUFramework;
using CPUWindowsFormFramework;
using RecipeAppSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipeClone : Form
    {
        DataTable dtnewrecipe = new();

        public frmRecipeClone()
        {
            InitializeComponent();
            BindData();
            btnClone.Click += BtnClone_Click;
        }

        private void BindData()
        {
            WindowsFormsUtility.SetListBinding(cmbRecipeName, DataMaintenance.GetDataList("Recipe", 0), null, "Recipe");
        }

        private void CloneRecipe()
        {
            int baserecipeid = WindowsFormsUtility.GetIdFromComboBox(cmbRecipeName);
            
            Cursor = Cursors.WaitCursor;
            try
            {
                int newrecipeid = Recipe.CloneRecipe(baserecipeid);
               
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
