using CPUFramework;
using CPUWindowsFormFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipes;

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select r.*, c.cuisinetype, u.username from recipe r join cuisinetype c on c.cuisinetypeid = r.cuisinetypeid join users u on u.usersid = r.usersid where r.recipeid = " + recipeid.ToString();
            dtrecipes = SQLUtility.GetDataTable(sql);
            if(recipeid == 0)
            {
                dtrecipes.Rows.Add();
            }
            DataTable dtcuisinetype = SQLUtility.GetDataTable("select CuisineTypeId, CuisineType from CuisineType");
            DataTable dtusers = SQLUtility.GetDataTable("select UsersId, UserName from Users");

            WindowsFormsUtility.SetListBinding(lstUserName, dtusers, dtrecipes, "Users");
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtcuisinetype, dtrecipes, "CuisineType");
            WindowsFormsUtility.SetControlBindings(txtRecipeName, dtrecipes);
            WindowsFormsUtility.SetControlBindings(txtCalories, dtrecipes);
            WindowsFormsUtility.SetControlBindings(txtDraftDate, dtrecipes);
            WindowsFormsUtility.SetControlBindings(txtPublishDate, dtrecipes);
            WindowsFormsUtility.SetControlBindings(txtArchiveDate, dtrecipes);
            WindowsFormsUtility.SetControlBindings(txtRecipeStatus, dtrecipes);
            this.Show();
        }

        private void Save()
        {
            DataRow r = dtrecipes.Rows[0];
            string sql = "";
            int id = (int)r["RecipeId"];

            string draftdate = txtDraftDate.Text != "" ? "'" + r["DraftDate"] + "'" : "'" + DateTime.Now.ToString() + "'";
                string publishdate = txtPublishDate.Text != "" ? "'" + r["PublishDate"] + "'" : "null";
                string archivedate = txtArchiveDate.Text != "" ? "'" + r["ArchiveDate"] + "'" : "null";

            if(id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update Recipe set",
                $"UsersId = '{r["UsersId"]} ',",
                $"CuisineTypeId = '{r["CuisineTypeId"]} ',",
                $"RecipeName = '{r["RecipeName"]} ',",
                $"Calories = {r["Calories"]} ,",
                $"DraftDate = " + draftdate + ", ",
                $"PublishDate = " + publishdate + ", ",
                $"ArchiveDate = " + archivedate + " ",
                $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert recipe (UsersId, CuisineTypeId, RecipeName, Calories, DraftDate, PublishDate, ArchiveDate)";
                sql += $"select '{r["UsersId"]}', '{r["CuisineTypeId"]}', '{r["RecipeName"]}', {r["Calories"]}, " + draftdate + "," + publishdate + "," + archivedate ;
            }

            Debug.Print("---------");
            SQLUtility.ExecuteSQL(sql);
        }

        private void Delete()
        {
            int id = (int)dtrecipes.Rows[0]["RecipeId"];
            string sql = "delete recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
