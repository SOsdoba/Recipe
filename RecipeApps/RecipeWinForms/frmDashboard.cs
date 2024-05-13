using RecipeAppSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;
            btnDashboardRecipeList.Click += BtnDashboardRecipeList_Click;
            btnDashboardMealList.Click += BtnDashboardMealList_Click;
            btnDashboardCookbookList.Click += BtnDashboardCookbookList_Click;
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            DataTable dt = DataMaintenance.GetDashboard();
            SetDashboardCount(dt, "Recipes", lblNumRecipes);
            SetDashboardCount(dt, "Meals", lblNumMeals);
            SetDashboardCount(dt, "Cookbooks", lblNumCookbooks);
            
        }

        private void SetDashboardCount(DataTable dt, string recordtype, Label lbl)
        {
            var rows = dt.Select($"DashboardType = '{recordtype}'");
            if(rows.Length > 0)
            {
                lbl.Text = rows[0]["DashboardNumber"].ToString();
            }
        }

        private void BtnDashboardRecipeList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmRecipeList));
        }

        private void BtnDashboardMealList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmMealList));
        }

        private void BtnDashboardCookbookList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmCookBookList));
        }

        private void ShowForm(Type f)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(f);
            }
        }

    }
}
