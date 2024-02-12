using CPUWindowsFormFramework;
using System.Data;
using RecipeAppSystem;

namespace RecipeWinForms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            btnNew.Click += BtnNew_Click;
            gRecipes.CellDoubleClick += GRecipes_CellDoubleClick;
            WindowsFormsUtility.FormatGridForSearchResults(gRecipes, "Recipe");
        }

        private void SearchForRecipe(string recipename)
        {
            DataTable dt = Recipe.SearchRecipes(recipename);
            gRecipes.DataSource = dt;
            gRecipes.Columns["RecipeId"].Visible = false;
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if(rowindex > -1)
            {
                id = (int)gRecipes.Rows[rowindex].Cells["RecipeId"].Value;
            }
            frmRecipe frm = new frmRecipe();
            frm.ShowForm(id);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }

        private void GRecipes_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtRecipeName.Text);
        }

    }
}
