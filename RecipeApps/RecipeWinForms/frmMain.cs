using CPUWindowsFormFramework;

namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuRecipesList.Click += MnuRecipesList_Click;
            mnuCookbookList.Click += MnuCookbookList_Click;
            mnuNewCookbook.Click += MnuNewCookbook_Click;
            mnuMealsList.Click += MnuMealsList_Click;
            mnuNewRecipe.Click += MnuNewRecipe_Click;
            mnuDashboard.Click += MnuDashboard_Click;
            mnuTile.Click += MnuTile_Click;
            mnuCascade.Click += MnuCascade_Click;
            mnuEditData.Click += MnuEditData_Click;
            mnuCloneARecipe.Click += MnuCloneARecipe_Click;
            mnuAutoCreateCookbook.Click += MnuAutoCreateCookbook_Click;
            this.Shown += FrmMain_Shown;
        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            frmLogin f = new() { StartPosition = FormStartPosition.CenterParent};
            bool b = f.ShowLogin();
            if(b == false)
            {
                this.Close();
                Application.Exit();
                return;
            }
            OpenForm(typeof(frmDashboard));
        }

        public void  OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype, pkvalue);
            
            if (b == false)
            {
                Form? newfrm = null;
                if (frmtype == typeof(frmRecipe))
                {
                    frmRecipe f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if (frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipeClone))
                {
                    frmRecipeClone f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookBookList))
                {
                    frmCookBookList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookBookClone))
                {
                    frmCookBookClone f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipeStatus))
                {
                    frmRecipeStatus f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if(frmtype == typeof(frmCookBook))
                {
                    frmCookBook f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if(frmtype == typeof(frmCookBookList))
                {
                    frmCookBookList f = new();
                    newfrm = f;
                }
                else if(frmtype == typeof(frmMeal))
                {
                    frmMeal f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if (frmtype == typeof(frmMealList))
                {
                    frmMealList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmDashboard))
                {
                    frmDashboard f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmDataMaintenance))
                {
                    frmDataMaintenance f = new();
                    newfrm = f;
                }
                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Frm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged;
                    newfrm.Show();
                }
                WindowsFormsUtility.SetupNav(tsMain);
            }
        }

        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }

        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }

        private void MnuCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MnuNewRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipe));
        }

        private void MnuNewCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookBook));
        }

        private void MnuCookbookList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookBookList));
        }

        private void MnuAutoCreateCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookBookClone));
        }

        private void MnuRecipesList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }

        private void MnuMealsList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealList));
        }

        private void MnuDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

        private void MnuEditData_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }

        private void MnuCloneARecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeClone));
        }


    }
}
