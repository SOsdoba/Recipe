using CPUFramework;
using CPUWindowsFormFramework;
using RecipeAppSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe = new();
        DataTable dtrecipeingredient = new();
        DataTable dtrecipesteps = new();
        BindingSource bindsource = new();
        int recipeid = 0;
        string deletecolname = "deletecol";
        bool formactivated = false;

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            this.FormClosing += FrmRecipe_FormClosing;
            this.Activated += FrmRecipe_Activated;
            btnSaveIngredient.Click += BtnSaveIngredient_Click;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            gSteps.CellContentClick += GSteps_CellContentClick;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            this.Shown += FrmRecipe_Shown;
        }

         public void FrmRecipe_Activated(object? sender, EventArgs e)
        {
            if(formactivated == true)
            {
                dtrecipe = Recipe.Load(recipeid);
                bindsource.DataSource = dtrecipe;
            }
            formactivated = true;
        }

        private void FrmRecipe_Shown(object? sender, EventArgs e)
        {
            LoadRecipeIngredient();
            LoadRecipeSteps();
        }

        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtusers = Recipe.GetUsersList(0);
            DataTable dtcuisinetype = Recipe.GetCuisineList();
            WindowsFormsUtility.SetListBinding(lstUserName, dtusers, dtrecipe, "Users");
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtcuisinetype, dtrecipe, "CuisineType");
            WindowsFormsUtility.SetControlBindings(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBindings(txtCalories, bindsource);
            WindowsFormsUtility.SetControlBindings(txtDraftDate, bindsource);
            WindowsFormsUtility.SetControlBindings(txtPublishDate, bindsource);
            WindowsFormsUtility.SetControlBindings(txtArchiveDate, bindsource);
            WindowsFormsUtility.SetControlBindings(txtRecipeStatus, bindsource);
            this.Text = GetRecipeDesc();
            SetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadRecipeIngredient()
        {
            dtrecipeingredient = RecipeIngredientsandSteps.LoadByRecipeId(recipeid, "RecipeIngredientGet");
            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtrecipeingredient;
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Ingredient", 1), "Ingredient", "IngredientName");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("MeasurementType", 1), "MeasurementType", "MeasurementType");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredients, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gIngredients, "RecipeIngredient");
            gIngredients.Columns["MeasurementTypeId"].Visible = false;
        }

        private void LoadRecipeSteps()
        {
            dtrecipesteps = RecipeIngredientsandSteps.LoadByRecipeId(recipeid, "RecipeStepsGet");
            gSteps.Columns.Clear();
            gSteps.DataSource = dtrecipesteps;
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gSteps, "RecipeSteps");
            gSteps.Columns["DirectionsId"].Visible = false;
            gSteps.Columns["RecipeId"].Visible = false;
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
                b = true;
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                this.Tag = recipeid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetRecipeDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }
       
        private void Delete()
        {
            string alloweddelete = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "IsDeleteAllowed");
            if (alloweddelete != "")
            {
                MessageBox.Show(alloweddelete, Application.ProductName);
                return;
            }
            var response = MessageBox.Show("Are you sure you want to delete this recipe?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
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

        private void SaveRecipeIngredients()
        {
            try
            {
                RecipeIngredientsandSteps.SaveTable(dtrecipeingredient, recipeid, "RecipeIngredientsUpdate");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void SaveRecipeSteps()
        {
            try
            {
                RecipeIngredientsandSteps.SaveTable(dtrecipesteps, recipeid, "RecipeStepsUpdate");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteRecipeIngredient(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gIngredients, rowindex, "RecipeIngredientId");
            if (id > 0)
            {
                try
                {
                    RecipeIngredientsandSteps.Delete(id, "RecipeIngredientDelete", "@RecipeIngredientId");
                    LoadRecipeIngredient();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gIngredients.Rows.Count)
            {
                gIngredients.Rows.RemoveAt(rowindex);
            }
        }

        private void DeleteRecipeSteps(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gSteps, rowindex, "DirectionsId");
            if (id > 0)
            {
                try
                {
                    RecipeIngredientsandSteps.Delete(id, "RecipeStepsDelete", "@DirectionsId");
                    LoadRecipeSteps();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gSteps.Rows.Count)
            {
                gSteps.Rows.RemoveAt(rowindex);
            }
        }

        private void ChangeRecipeStatus()
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeStatus), recipeid);
            }
        }

        private void FrmRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtrecipe))
            {
                var response = MessageBox.Show($"Do you want to save changes to {this.Text} before closing?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (response)
                {
                    case DialogResult.Yes:
                        bool b = Save();
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

        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = "Recipe - " + SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return value;
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnChangeStatus.Enabled = b;
            btnSaveSteps.Enabled = b;
            btnSaveIngredient.Enabled = b;
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            SaveRecipeSteps();
        }

        private void BtnSaveIngredient_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredients();
        }

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            ChangeRecipeStatus();
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            string columnname = gIngredients.Columns[e.ColumnIndex].Name;

            if (gIngredients.Rows[e.RowIndex].IsNewRow == true)
            {
                gIngredients.Columns[e.ColumnIndex].ReadOnly = true;
            }
            else if (columnname == deletecolname && gIngredients.Rows[e.RowIndex].IsNewRow != true)
            {
                DeleteRecipeIngredient(e.RowIndex);
            }
        }

        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            string columnname = gSteps.Columns[e.ColumnIndex].Name;
            
            if (gSteps.Rows[e.RowIndex].IsNewRow == true)
            {
                gSteps.Columns[e.ColumnIndex].ReadOnly = true;
            }
            else if (columnname == deletecolname && gSteps.Rows[e.RowIndex].IsNewRow != true)
            {
                DeleteRecipeSteps(e.RowIndex);
            }

        }
    }
}
