using CPUFramework;
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
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select r.*, c.cuisinetype, u.username from recipe r join cuisinetype c on c.cuisinetypeid = r.cuisinetypeid join users u on u.usersid = r.usersid where r.recipeid = " + recipeid.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            lblUserName.DataBindings.Add("Text", dt, "UserName");
            lblCuisineType.DataBindings.Add("Text", dt, "CuisineType");
            txtRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            txtCalories.DataBindings.Add("Text", dt, "Calories");
            txtDraftDate.DataBindings.Add("Text", dt, "DraftDate");
            txtPublishDate.DataBindings.Add("Text", dt, "PublishDate");
            txtArchiveDate.DataBindings.Add("Text", dt, "ArchiveDate");
            txtStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            this.Show();
        }
    }
}
