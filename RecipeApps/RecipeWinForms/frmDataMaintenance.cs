using CPUFramework;
using CPUWindowsFormFramework;
using RecipeAppSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum {Users, CuisineType, Ingredient, MeasurementType, CourseType}
        DataTable dtlist = new();
        TableTypeEnum currenttabletype = TableTypeEnum.Users;
        string deletecolname = "deletecol";

        public frmDataMaintenance()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            this.FormClosing += FrmDataMaintenance_FormClosing;
            gData.CellContentClick += GData_CellContentClick;
            SetupRadioButtons();
            BindData(currenttabletype);
            gData.EditingControlShowing += GData_EditingControlShowing;
        }

        private void GData_EditingControlShowing(object? sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Sequence_KeyPress);
            if (currenttabletype.ToString() == "CourseType" && gData.CurrentCell.ColumnIndex == 2)
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

        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString(), 0);
            gData.Columns.Clear();
            gData.DataSource = dtlist;

            WindowsFormsUtility.AddDeleteButtonToGrid(gData, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gData, tabletype.ToString());
        }

        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.SaveDataList(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;
        }

        private void Delete(int rowIndex)
        {
            string rowid = currenttabletype.ToString() + "Id";
            if(currenttabletype.ToString() == "CourseType")
            {
                rowid = "CourseId";
            }
            int id = WindowsFormsUtility.GetIdFromGrid(gData, rowIndex, rowid);
            if(id > 0)
            {
                string recordtype = currenttabletype.ToString();
                string message = $"Do you want to delete this {recordtype}?";
                if (currenttabletype.ToString() == "Users")
                {
                    message = "Are you sure you want to delete this user and all related recipes, meals, and cookbooks?";
                }
                var response = MessageBox.Show(message, Application.ProductName, MessageBoxButtons.YesNoCancel);

                switch (response)
                {
                    case DialogResult.Yes:
                        try
                        {
                            DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                            BindData(currenttabletype);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, Application.ProductName);
                        }
                        break;
                    case DialogResult.Cancel:
                        this.Activate();
                        break;
                }
            }
            else if(id < gData.Rows.Count)
            {
                gData.Rows.RemoveAt(rowIndex);
            }
        }

        private void SetupRadioButtons()
        {
            foreach(Control c in pnlOptions.Controls)
            {
                if(c is RadioButton)
                {
                    c.Click += C_Click;
                }
            }
            optUsers.Tag = TableTypeEnum.Users;
            optCuisines.Tag = TableTypeEnum.CuisineType;
            optIngredients.Tag = TableTypeEnum.Ingredient;
            optMeasurements.Tag = TableTypeEnum.MeasurementType;
            optCourses.Tag = TableTypeEnum.CourseType;
        }
        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SQLUtility.TableHasChanges(dtlist))
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

        private void C_Click(object? sender, EventArgs e)
        {
            if(sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        
        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                if (gData.Rows[e.RowIndex].IsNewRow == true)
                {
                    gData.Columns[e.ColumnIndex].ReadOnly = true;
                }
                else if (gData.Columns[e.ColumnIndex].Name == deletecolname && (gData.Rows[e.RowIndex].IsNewRow != true))
                {
                    Delete(e.RowIndex); ;
                }
            }      
        }
    }
}