using CPUWindowsFormFramework;
using Microsoft.VisualBasic.ApplicationServices;
using RecipeAppSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RecipeWinForms
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            ShowMealList();
            gMeals.CellDoubleClick += GMeals_CellDoubleClick;
            gMeals.KeyDown += GMeals_KeyDown;
        }

        private void ShowMealList()
        {
            DataTable dt = Meals.SearchMeals();
            gMeals.DataSource = dt;
            gMeals.Columns["MealId"].Visible = false;
            gMeals.Columns["MealActive"].Visible = false;
            gMeals.Columns["DateMealCreated"].Visible = false;
        }

        private void ShowMealForm(int rowindex)
        {
            int id = 0;
            if(rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gMeals, rowindex, "MealId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmMeal), id);
            }
        }

        private void GMeals_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gMeals.SelectedRows.Count > 0)
            {
                ShowMealForm(gMeals.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void GMeals_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowMealForm(e.RowIndex);
        }
    }
}
