using CPUFramework;
using CPUWindowsFormFramework;
using RecipeAppSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmCookBook : Form
    {
        DataTable dtcookbook = new();
        DataTable dtcookbookrecipes = new();
        BindingSource bindsource = new();
        int cookbookid = 0;
        string deletecolname = "deletecol";

        public frmCookBook()
        {
            InitializeComponent();
            this.FormClosing += FrmCookBook_FormClosing;
            btnSaveCookBook.Click += BtnSaveCookBook_Click;
            btnDeleteCookBook.Click += BtnDeleteCookBook_Click;
            btnSaveCookBookRecipes.Click += BtnSaveCookBookRecipes_Click;
            gCookBookRecipes.CellContentClick += GCookBookRecipes_CellContentClick;
            this.Shown += FrmCookBook_Shown;
            txtPrice.KeyPress += TxtPrice_KeyPress;
            gCookBookRecipes.EditingControlShowing += GCookBookRecipes_EditingControlShowing;
        }

        private void FrmCookBook_Shown(object? sender, EventArgs e)
        {
            LoadCookBookRecipes();
        }

        private bool SaveCookBook()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                CookBooks.Save(dtcookbook);
                b = true;
                bindsource.ResetBindings(true);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookBookId");
                this.Tag = cookbookid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = CookBookDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CookBook");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void DeleteCookBook()
        {
            var response = MessageBox.Show("Are you sure you want to delete this cookbook?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                CookBooks.Delete(dtcookbook);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void FrmCookBook_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtcookbook))
            {
                var response = MessageBox.Show($"Do you want to save changes to {this.Text} before closing?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (response)
                {
                    case DialogResult.Yes:
                        bool b = SaveCookBook();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }

        public void LoadForm(int cookbookidval)
        {
            cookbookid = cookbookidval;
            this.Tag = cookbookid;
            dtcookbook = CookBooks.Load(cookbookid);
            bindsource.DataSource = dtcookbook;
            if (cookbookid == 0)
            {
                dtcookbook.Rows.Add();
            }
            DataTable dtusers = Recipe.GetUsersList(1);
            WindowsFormsUtility.SetListBinding(lstUserName, dtusers,dtcookbook, "Users");
            WindowsFormsUtility.SetControlBindings(txtCookBookName, bindsource);
            WindowsFormsUtility.SetControlBindings(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBindings(txtDateBookCreated, bindsource);
            chkCookBookActive.DataBindings.Add("Checked", bindsource, "CookBookActive", true, DataSourceUpdateMode.OnPropertyChanged);
            
            this.Text = CookBookDesc();
            SetButtonsEnabledBasedOnNewRecord();
        }
        

        private void LoadCookBookRecipes()
        {
            dtcookbookrecipes = CookBook_Recipes.LoadByCookBookId(cookbookid);
            gCookBookRecipes.Columns.Clear();
            gCookBookRecipes.DataSource = dtcookbookrecipes;
            WindowsFormsUtility.AddComboBoxToGrid(gCookBookRecipes, DataMaintenance.GetDataList("Recipe", 0), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gCookBookRecipes, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gCookBookRecipes, "CookBookRecipe");
            gCookBookRecipes.Columns["CookBookId"].Visible = false;
            gCookBookRecipes.Columns["RecipeId"].Visible = false;

        }

        private void SaveCookBookRecipes()
        {
            try
            {
                CookBook_Recipes.SaveTable(dtcookbookrecipes,cookbookid, "CookBookRecipesUpdate");
                LoadCookBookRecipes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteCookBookRecipes(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gCookBookRecipes, rowindex, "CookBookRecipesId");
            if (id > 0)
            {
                try
                {
                    CookBook_Recipes.Delete(id);
                    LoadCookBookRecipes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gCookBookRecipes.Rows.Count)
            {
                gCookBookRecipes.Rows.RemoveAt(rowindex);
            }
        }
        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDeleteCookBook.Enabled = b;
            btnSaveCookBookRecipes.Enabled = b;
        }

        private string CookBookDesc()
        {
            string value = "New CookBook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookBookId");
            if (pkvalue > 0)
            {
                value = "Cookbook - " + SQLUtility.GetValueFromFirstRowAsString(dtcookbook, "CookBookName");
            }
            return value;
        }

        private void BtnSaveCookBookRecipes_Click(object? sender, EventArgs e)
        {
            SaveCookBookRecipes();
        }

        private void BtnSaveCookBook_Click(object? sender, EventArgs e)
        {
             SaveCookBook();
        }

        private void BtnDeleteCookBook_Click(object? sender, EventArgs e)
        {
            DeleteCookBook();
        }

        private void GCookBookRecipes_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            string columnname = gCookBookRecipes.Columns[e.ColumnIndex].Name;

            if(e.RowIndex > -1)
            {
                if (gCookBookRecipes.Rows[e.RowIndex].IsNewRow == true)
                {
                    gCookBookRecipes.Columns[e.ColumnIndex].ReadOnly = true;
                }
                else if (columnname == deletecolname && gCookBookRecipes.Rows[e.RowIndex].IsNewRow != true)
                {
                    DeleteCookBookRecipes(e.RowIndex);
                }
            }
        }

        private void TxtPrice_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Only a numeric value can be inserted.");
            }
        }

        private void GCookBookRecipes_EditingControlShowing(object? sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Sequence_KeyPress);
            if (gCookBookRecipes.CurrentCell.ColumnIndex == 4)
            {
                TextBox t = e.Control as TextBox;
                t.KeyPress += new KeyPressEventHandler(Sequence_KeyPress);
            }
        }

        private void Sequence_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only a numeric value can be inserted.");
            }
        }
    }
}