using CPUWindowsFormFramework;
using System.Data;
using RecipeAppSystem;

namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            this.Activated += FrmRecipeList_Activated;
            ShowRecipeList();
            btnNewRecipe.Click += BtnNew_Click;
            gRecipes.CellDoubleClick += GRecipes_CellDoubleClick;
            gRecipes.KeyDown += GRecipes_KeyDown1;
            WindowsFormsUtility.FormatGridForSearchResults(gRecipes, "Recipe");
        }

        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            ShowRecipeList();
            WindowsFormsUtility.FormatGridForSearchResults(gRecipes, "Recipe");
        }

        public void ShowRecipeList()
        {
            DataTable dt = Recipe.SearchRecipes();
            gRecipes.DataSource = dt;
            gRecipes.Columns["UsersId"].Visible = false;
            gRecipes.Columns["CuisineTypeId"].Visible = false;
            gRecipes.Columns["DraftDate"].Visible = false;
            gRecipes.Columns["PublishDate"].Visible = false;
            gRecipes.Columns["ArchiveDate"].Visible = false;
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if(rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gRecipes, rowindex, "RecipeId");
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
                }
            }
        }

        private void GRecipes_KeyDown1(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gRecipes.SelectedRows.Count > 0)
            {
                ShowRecipeForm(gRecipes.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }

        private void GRecipes_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

    }
}
