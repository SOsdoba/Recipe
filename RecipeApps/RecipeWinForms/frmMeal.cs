using CPUFramework;
using CPUWindowsFormFramework;
using RecipeAppSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmMeal : Form
    {
        DataTable dtmeal = new DataTable();
        BindingSource bindsource = new BindingSource();
        int mealid = 0;

        public frmMeal()
        {
            InitializeComponent();
        }

        public void LoadForm(int mealidval)
        {
            mealid = mealidval;
            this.Tag = mealid;
            dtmeal = Meals.Load(mealid);
            bindsource.DataSource = dtmeal;
            WindowsFormsUtility.SetControlBindings(txtMealName, bindsource);
            WindowsFormsUtility.SetControlBindings(txtCreator, bindsource);
            WindowsFormsUtility.SetControlBindings(txtNumCalories, bindsource);
            WindowsFormsUtility.SetControlBindings(txtNumCourses, bindsource);
            WindowsFormsUtility.SetControlBindings(txtNumRecipes, bindsource);
            WindowsFormsUtility.SetControlBindings(txtMealActive, bindsource);
            WindowsFormsUtility.SetControlBindings(txtDateMealCreated, bindsource);
            this.Text = MealDesc();
        }

        private string MealDesc()
        {
            string value = "";
            value = SQLUtility.GetValueFromFirstRowAsString(dtmeal, "MealName");
            return value;
        }
    }
}
