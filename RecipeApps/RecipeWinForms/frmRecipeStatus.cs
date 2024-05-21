using CPUFramework;
using CPUWindowsFormFramework;
using RecipeAppSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipeStatus : Form
    {
        DataTable dtrecipe = new();
        BindingSource bindsource = new();
        int recipeid = 0;

        public frmRecipeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
            btnArchive.Click += BtnArchive_Click;
        }

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to change this recipe to archived?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                txtArchiveDate.Text = DateTime.Now.ToString();
                Recipe.Save(dtrecipe);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                dtrecipe = Recipe.Load(recipeid);
                bindsource.DataSource = dtrecipe;
                SetButtonsEnabled();
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

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to change this recipe to published?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                dtrecipe.Rows[0]["Archivedate"] = DBNull.Value;
                txtArchiveDate.Text = null;
                txtPublishDate.Text = DateTime.Now.ToString();
                Recipe.Save(dtrecipe);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                dtrecipe = Recipe.Load(recipeid);
                bindsource.DataSource = dtrecipe;
                SetButtonsEnabled();
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

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to change this recipe status to drafted?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                dtrecipe.Rows[0]["publishdate"] = DBNull.Value;
                dtrecipe.Rows[0]["archivedate"] = DBNull.Value;
                txtDraftDate.Text = DateTime.Now.ToString();
                Recipe.Save(dtrecipe);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                dtrecipe = Recipe.Load(recipeid);
                bindsource.DataSource = dtrecipe;
                SetButtonsEnabled();
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

            public void LoadForm(int recipeidval)
            {
                recipeid = recipeidval;
                this.Tag = recipeid;
                dtrecipe = Recipe.Load(recipeid);
                bindsource.DataSource = dtrecipe;
                WindowsFormsUtility.SetControlBindings(lblRecipeName, bindsource);
                WindowsFormsUtility.SetControlBindings(lblRecipeStatus, bindsource);
                WindowsFormsUtility.SetControlBindings(txtDraftDate, bindsource);
                WindowsFormsUtility.SetControlBindings(txtPublishDate, bindsource);
                WindowsFormsUtility.SetControlBindings(txtArchiveDate, bindsource);
                SetButtonsEnabled();
            }

            private void SetButtonsEnabled()
            {
                string status = dtrecipe.Rows[0].Field<string>("RecipeStatus");

                btnDraft.Enabled = true;
                btnPublish.Enabled = true;
                btnArchive.Enabled = true;

                if (status == "Draft")
                {
                    btnDraft.Enabled = false;
                }
                else if (status == "Published")
                {
                    btnPublish.Enabled = false;
                }
                else if (status == "Archived")
                {
                    btnArchive.Enabled = false;
                }
            }
    }
}