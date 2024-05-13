namespace RecipeWinForms
{
    partial class frmMeal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblMealName = new System.Windows.Forms.Label();
            this.txtMealName = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtCreator = new System.Windows.Forms.TextBox();
            this.lblNumCalories = new System.Windows.Forms.Label();
            this.txtNumCalories = new System.Windows.Forms.TextBox();
            this.lblNumCourses = new System.Windows.Forms.Label();
            this.txtNumCourses = new System.Windows.Forms.TextBox();
            this.lblNumRecipes = new System.Windows.Forms.Label();
            this.txtNumRecipes = new System.Windows.Forms.TextBox();
            this.lblMealActive = new System.Windows.Forms.Label();
            this.txtMealActive = new System.Windows.Forms.TextBox();
            this.txtDateMealCreated = new System.Windows.Forms.TextBox();
            this.lblDateMealCreated = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.lblMealName, 0, 0);
            this.tblMain.Controls.Add(this.txtMealName, 1, 0);
            this.tblMain.Controls.Add(this.lblUser, 0, 1);
            this.tblMain.Controls.Add(this.txtCreator, 1, 1);
            this.tblMain.Controls.Add(this.lblNumCalories, 0, 2);
            this.tblMain.Controls.Add(this.txtNumCalories, 1, 2);
            this.tblMain.Controls.Add(this.lblNumCourses, 0, 3);
            this.tblMain.Controls.Add(this.txtNumCourses, 1, 3);
            this.tblMain.Controls.Add(this.lblNumRecipes, 0, 4);
            this.tblMain.Controls.Add(this.txtNumRecipes, 1, 4);
            this.tblMain.Controls.Add(this.lblMealActive, 0, 5);
            this.tblMain.Controls.Add(this.txtMealActive, 1, 5);
            this.tblMain.Controls.Add(this.txtDateMealCreated, 1, 6);
            this.tblMain.Controls.Add(this.lblDateMealCreated, 0, 6);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 8;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(1029, 630);
            this.tblMain.TabIndex = 0;
            // 
            // lblMealName
            // 
            this.lblMealName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMealName.AutoSize = true;
            this.lblMealName.Location = new System.Drawing.Point(3, 7);
            this.lblMealName.Name = "lblMealName";
            this.lblMealName.Size = new System.Drawing.Size(105, 21);
            this.lblMealName.TabIndex = 0;
            this.lblMealName.Text = "Meal Name";
            this.lblMealName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMealName
            // 
            this.txtMealName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMealName.Enabled = false;
            this.txtMealName.Location = new System.Drawing.Point(114, 3);
            this.txtMealName.Name = "txtMealName";
            this.txtMealName.Size = new System.Drawing.Size(912, 29);
            this.txtMealName.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(3, 42);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(105, 21);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCreator
            // 
            this.txtCreator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCreator.Enabled = false;
            this.txtCreator.Location = new System.Drawing.Point(114, 38);
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.Size = new System.Drawing.Size(912, 29);
            this.txtCreator.TabIndex = 3;
            // 
            // lblNumCalories
            // 
            this.lblNumCalories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumCalories.AutoSize = true;
            this.lblNumCalories.Location = new System.Drawing.Point(3, 77);
            this.lblNumCalories.Name = "lblNumCalories";
            this.lblNumCalories.Size = new System.Drawing.Size(105, 21);
            this.lblNumCalories.TabIndex = 4;
            this.lblNumCalories.Text = "Num Calories";
            this.lblNumCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumCalories
            // 
            this.txtNumCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumCalories.Enabled = false;
            this.txtNumCalories.Location = new System.Drawing.Point(114, 73);
            this.txtNumCalories.Name = "txtNumCalories";
            this.txtNumCalories.Size = new System.Drawing.Size(912, 29);
            this.txtNumCalories.TabIndex = 5;
            // 
            // lblNumCourses
            // 
            this.lblNumCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumCourses.AutoSize = true;
            this.lblNumCourses.Location = new System.Drawing.Point(3, 112);
            this.lblNumCourses.Name = "lblNumCourses";
            this.lblNumCourses.Size = new System.Drawing.Size(105, 21);
            this.lblNumCourses.TabIndex = 6;
            this.lblNumCourses.Text = "Num Courses";
            this.lblNumCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumCourses
            // 
            this.txtNumCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumCourses.Enabled = false;
            this.txtNumCourses.Location = new System.Drawing.Point(114, 108);
            this.txtNumCourses.Name = "txtNumCourses";
            this.txtNumCourses.Size = new System.Drawing.Size(912, 29);
            this.txtNumCourses.TabIndex = 7;
            // 
            // lblNumRecipes
            // 
            this.lblNumRecipes.AutoSize = true;
            this.lblNumRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumRecipes.Location = new System.Drawing.Point(3, 140);
            this.lblNumRecipes.Name = "lblNumRecipes";
            this.lblNumRecipes.Size = new System.Drawing.Size(105, 35);
            this.lblNumRecipes.TabIndex = 8;
            this.lblNumRecipes.Text = "Num Recipes";
            this.lblNumRecipes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumRecipes
            // 
            this.txtNumRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumRecipes.Enabled = false;
            this.txtNumRecipes.Location = new System.Drawing.Point(114, 143);
            this.txtNumRecipes.Name = "txtNumRecipes";
            this.txtNumRecipes.Size = new System.Drawing.Size(912, 29);
            this.txtNumRecipes.TabIndex = 9;
            // 
            // lblMealActive
            // 
            this.lblMealActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMealActive.AutoSize = true;
            this.lblMealActive.Location = new System.Drawing.Point(3, 182);
            this.lblMealActive.Name = "lblMealActive";
            this.lblMealActive.Size = new System.Drawing.Size(105, 21);
            this.lblMealActive.TabIndex = 10;
            this.lblMealActive.Text = "Meal Active";
            // 
            // txtMealActive
            // 
            this.txtMealActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMealActive.Enabled = false;
            this.txtMealActive.Location = new System.Drawing.Point(114, 178);
            this.txtMealActive.Name = "txtMealActive";
            this.txtMealActive.Size = new System.Drawing.Size(912, 29);
            this.txtMealActive.TabIndex = 11;
            // 
            // txtDateMealCreated
            // 
            this.txtDateMealCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateMealCreated.Enabled = false;
            this.txtDateMealCreated.Location = new System.Drawing.Point(114, 213);
            this.txtDateMealCreated.Name = "txtDateMealCreated";
            this.txtDateMealCreated.Size = new System.Drawing.Size(912, 29);
            this.txtDateMealCreated.TabIndex = 12;
            // 
            // lblDateMealCreated
            // 
            this.lblDateMealCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateMealCreated.AutoSize = true;
            this.lblDateMealCreated.Location = new System.Drawing.Point(3, 217);
            this.lblDateMealCreated.Name = "lblDateMealCreated";
            this.lblDateMealCreated.Size = new System.Drawing.Size(105, 21);
            this.lblDateMealCreated.TabIndex = 13;
            this.lblDateMealCreated.Text = "Date Created";
            // 
            // frmMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMeal";
            this.Text = "Meal";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblMealName;
        private TextBox txtMealName;
        private Label lblUser;
        private TextBox txtCreator;
        private Label lblNumCalories;
        private TextBox txtNumCalories;
        private Label lblNumCourses;
        private TextBox txtNumCourses;
        private Label lblNumRecipes;
        private TextBox txtNumRecipes;
        private Label lblMealActive;
        private TextBox txtMealActive;
        private TextBox txtDateMealCreated;
        private Label lblDateMealCreated;
    }
}