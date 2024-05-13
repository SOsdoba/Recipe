namespace RecipeWinForms
{
    partial class frmDashboard
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
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.lblDashboardDesc = new System.Windows.Forms.Label();
            this.tblDashboardInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRecipes = new System.Windows.Forms.Label();
            this.lblMeals = new System.Windows.Forms.Label();
            this.lblCookbooks = new System.Windows.Forms.Label();
            this.lblDashboardNumber = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDashboardRecipeList = new System.Windows.Forms.Button();
            this.btnDashboardMealList = new System.Windows.Forms.Button();
            this.btnDashboardCookbookList = new System.Windows.Forms.Button();
            this.lblNumRecipes = new System.Windows.Forms.Label();
            this.lblNumMeals = new System.Windows.Forms.Label();
            this.lblNumCookbooks = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            this.tblDashboardInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblMain.ColumnCount = 4;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.Controls.Add(this.lblDashboardTitle, 1, 0);
            this.tblMain.Controls.Add(this.lblDashboardDesc, 1, 1);
            this.tblMain.Controls.Add(this.tblDashboardInfo, 1, 2);
            this.tblMain.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(1029, 630);
            this.tblMain.TabIndex = 0;
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDashboardTitle.AutoSize = true;
            this.tblMain.SetColumnSpan(this.lblDashboardTitle, 2);
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDashboardTitle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblDashboardTitle.Location = new System.Drawing.Point(261, 85);
            this.lblDashboardTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(506, 46);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Hearty Hearth Desktop App";
            this.lblDashboardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDashboardDesc
            // 
            this.lblDashboardDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDashboardDesc.AutoSize = true;
            this.tblMain.SetColumnSpan(this.lblDashboardDesc, 2);
            this.lblDashboardDesc.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDashboardDesc.Location = new System.Drawing.Point(260, 131);
            this.lblDashboardDesc.Name = "lblDashboardDesc";
            this.lblDashboardDesc.Size = new System.Drawing.Size(508, 131);
            this.lblDashboardDesc.TabIndex = 1;
            this.lblDashboardDesc.Text = "Welcome to the Hearty Hearth desktop app. In this app you can create recipes and " +
    "cookbooks. You can also...";
            this.lblDashboardDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblDashboardInfo
            // 
            this.tblDashboardInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblDashboardInfo.ColumnCount = 2;
            this.tblMain.SetColumnSpan(this.tblDashboardInfo, 2);
            this.tblDashboardInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboardInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboardInfo.Controls.Add(this.lblType, 0, 0);
            this.tblDashboardInfo.Controls.Add(this.lblRecipes, 0, 1);
            this.tblDashboardInfo.Controls.Add(this.lblMeals, 0, 2);
            this.tblDashboardInfo.Controls.Add(this.lblCookbooks, 0, 3);
            this.tblDashboardInfo.Controls.Add(this.lblDashboardNumber, 1, 0);
            this.tblDashboardInfo.Controls.Add(this.lblNumRecipes, 1, 1);
            this.tblDashboardInfo.Controls.Add(this.lblNumMeals, 1, 2);
            this.tblDashboardInfo.Controls.Add(this.lblNumCookbooks, 1, 3);
            this.tblDashboardInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashboardInfo.Location = new System.Drawing.Point(260, 265);
            this.tblDashboardInfo.Name = "tblDashboardInfo";
            this.tblDashboardInfo.RowCount = 4;
            this.tblDashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDashboardInfo.Size = new System.Drawing.Size(508, 256);
            this.tblDashboardInfo.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Location = new System.Drawing.Point(4, 1);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(246, 62);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipes.Location = new System.Drawing.Point(4, 64);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(246, 62);
            this.lblRecipes.TabIndex = 1;
            this.lblRecipes.Text = "Recipes";
            this.lblRecipes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMeals
            // 
            this.lblMeals.AutoSize = true;
            this.lblMeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeals.Location = new System.Drawing.Point(4, 127);
            this.lblMeals.Name = "lblMeals";
            this.lblMeals.Size = new System.Drawing.Size(246, 62);
            this.lblMeals.TabIndex = 2;
            this.lblMeals.Text = "Meals";
            this.lblMeals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCookbooks
            // 
            this.lblCookbooks.AutoSize = true;
            this.lblCookbooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCookbooks.Location = new System.Drawing.Point(4, 190);
            this.lblCookbooks.Name = "lblCookbooks";
            this.lblCookbooks.Size = new System.Drawing.Size(246, 65);
            this.lblCookbooks.TabIndex = 3;
            this.lblCookbooks.Text = "Cookbooks";
            this.lblCookbooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDashboardNumber
            // 
            this.lblDashboardNumber.AutoSize = true;
            this.lblDashboardNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDashboardNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDashboardNumber.Location = new System.Drawing.Point(257, 1);
            this.lblDashboardNumber.Name = "lblDashboardNumber";
            this.lblDashboardNumber.Size = new System.Drawing.Size(247, 62);
            this.lblDashboardNumber.TabIndex = 4;
            this.lblDashboardNumber.Text = "Number";
            this.lblDashboardNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tblMain.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnDashboardRecipeList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDashboardMealList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDashboardCookbookList, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(260, 527);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(508, 100);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnDashboardRecipeList
            // 
            this.btnDashboardRecipeList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDashboardRecipeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDashboardRecipeList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDashboardRecipeList.FlatAppearance.BorderSize = 3;
            this.btnDashboardRecipeList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDashboardRecipeList.Location = new System.Drawing.Point(3, 3);
            this.btnDashboardRecipeList.Name = "btnDashboardRecipeList";
            this.btnDashboardRecipeList.Size = new System.Drawing.Size(163, 94);
            this.btnDashboardRecipeList.TabIndex = 0;
            this.btnDashboardRecipeList.Text = "Recipe List";
            this.btnDashboardRecipeList.UseVisualStyleBackColor = false;
            // 
            // btnDashboardMealList
            // 
            this.btnDashboardMealList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDashboardMealList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDashboardMealList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDashboardMealList.FlatAppearance.BorderSize = 3;
            this.btnDashboardMealList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDashboardMealList.Location = new System.Drawing.Point(172, 3);
            this.btnDashboardMealList.Name = "btnDashboardMealList";
            this.btnDashboardMealList.Size = new System.Drawing.Size(163, 94);
            this.btnDashboardMealList.TabIndex = 1;
            this.btnDashboardMealList.Text = "Meal List";
            this.btnDashboardMealList.UseVisualStyleBackColor = false;
            // 
            // btnDashboardCookbookList
            // 
            this.btnDashboardCookbookList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDashboardCookbookList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDashboardCookbookList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDashboardCookbookList.FlatAppearance.BorderSize = 3;
            this.btnDashboardCookbookList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDashboardCookbookList.Location = new System.Drawing.Point(341, 3);
            this.btnDashboardCookbookList.Name = "btnDashboardCookbookList";
            this.btnDashboardCookbookList.Size = new System.Drawing.Size(164, 94);
            this.btnDashboardCookbookList.TabIndex = 2;
            this.btnDashboardCookbookList.Text = "Cookbook List";
            this.btnDashboardCookbookList.UseVisualStyleBackColor = false;
            // 
            // lblNumRecipes
            // 
            this.lblNumRecipes.AutoSize = true;
            this.lblNumRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumRecipes.Location = new System.Drawing.Point(257, 64);
            this.lblNumRecipes.Name = "lblNumRecipes";
            this.lblNumRecipes.Size = new System.Drawing.Size(247, 62);
            this.lblNumRecipes.TabIndex = 5;
            this.lblNumRecipes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumMeals
            // 
            this.lblNumMeals.AutoSize = true;
            this.lblNumMeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumMeals.Location = new System.Drawing.Point(257, 127);
            this.lblNumMeals.Name = "lblNumMeals";
            this.lblNumMeals.Size = new System.Drawing.Size(247, 62);
            this.lblNumMeals.TabIndex = 6;
            this.lblNumMeals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumCookbooks
            // 
            this.lblNumCookbooks.AutoSize = true;
            this.lblNumCookbooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumCookbooks.Location = new System.Drawing.Point(257, 190);
            this.lblNumCookbooks.Name = "lblNumCookbooks";
            this.lblNumCookbooks.Size = new System.Drawing.Size(247, 65);
            this.lblNumCookbooks.TabIndex = 7;
            this.lblNumCookbooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblDashboardInfo.ResumeLayout(false);
            this.tblDashboardInfo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblDashboardTitle;
        private Label lblDashboardDesc;
        private TableLayoutPanel tblDashboardInfo;
        private Label lblType;
        private Label lblRecipes;
        private Label lblMeals;
        private Label lblCookbooks;
        private Label lblDashboardNumber;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnDashboardRecipeList;
        private Button btnDashboardMealList;
        private Button btnDashboardCookbookList;
        private Label lblNumRecipes;
        private Label lblNumMeals;
        private Label lblNumCookbooks;
    }
}