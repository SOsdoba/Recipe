namespace RecipeWinForms
{
    partial class frmRecipe
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCaptionCalories = new System.Windows.Forms.Label();
            this.lblCaptionRecipeName = new System.Windows.Forms.Label();
            this.lblCaptionDraftDate = new System.Windows.Forms.Label();
            this.lblCaptionPublishDate = new System.Windows.Forms.Label();
            this.lblCaptionArchiveDate = new System.Windows.Forms.Label();
            this.lblCaptionRecipeStatus = new System.Windows.Forms.Label();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.txtDraftDate = new System.Windows.Forms.TextBox();
            this.txtPublishDate = new System.Windows.Forms.TextBox();
            this.txtArchiveDate = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblCaptionUserName = new System.Windows.Forms.Label();
            this.lblCaptionCuisineType = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCuisineType = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblCaptionCalories, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCaptionRecipeName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCaptionDraftDate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCaptionPublishDate, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCaptionArchiveDate, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblCaptionRecipeStatus, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtCalories, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDraftDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPublishDate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtArchiveDate, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtStatus, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtRecipeName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCaptionUserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCaptionCuisineType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUserName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCuisineType, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(438, 322);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCaptionCalories
            // 
            this.lblCaptionCalories.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCalories.AutoSize = true;
            this.lblCaptionCalories.Location = new System.Drawing.Point(3, 129);
            this.lblCaptionCalories.Name = "lblCaptionCalories";
            this.lblCaptionCalories.Size = new System.Drawing.Size(66, 21);
            this.lblCaptionCalories.TabIndex = 3;
            this.lblCaptionCalories.Text = "Calories";
            // 
            // lblCaptionRecipeName
            // 
            this.lblCaptionRecipeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionRecipeName.AutoSize = true;
            this.lblCaptionRecipeName.Location = new System.Drawing.Point(3, 89);
            this.lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            this.lblCaptionRecipeName.Size = new System.Drawing.Size(102, 21);
            this.lblCaptionRecipeName.TabIndex = 8;
            this.lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionDraftDate
            // 
            this.lblCaptionDraftDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDraftDate.AutoSize = true;
            this.lblCaptionDraftDate.Location = new System.Drawing.Point(3, 169);
            this.lblCaptionDraftDate.Name = "lblCaptionDraftDate";
            this.lblCaptionDraftDate.Size = new System.Drawing.Size(81, 21);
            this.lblCaptionDraftDate.TabIndex = 4;
            this.lblCaptionDraftDate.Text = "Draft Date";
            // 
            // lblCaptionPublishDate
            // 
            this.lblCaptionPublishDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionPublishDate.AutoSize = true;
            this.lblCaptionPublishDate.Location = new System.Drawing.Point(3, 209);
            this.lblCaptionPublishDate.Name = "lblCaptionPublishDate";
            this.lblCaptionPublishDate.Size = new System.Drawing.Size(97, 21);
            this.lblCaptionPublishDate.TabIndex = 5;
            this.lblCaptionPublishDate.Text = "Publish Date";
            // 
            // lblCaptionArchiveDate
            // 
            this.lblCaptionArchiveDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionArchiveDate.AutoSize = true;
            this.lblCaptionArchiveDate.Location = new System.Drawing.Point(3, 249);
            this.lblCaptionArchiveDate.Name = "lblCaptionArchiveDate";
            this.lblCaptionArchiveDate.Size = new System.Drawing.Size(98, 21);
            this.lblCaptionArchiveDate.TabIndex = 6;
            this.lblCaptionArchiveDate.Text = "Archive Date";
            // 
            // lblCaptionRecipeStatus
            // 
            this.lblCaptionRecipeStatus.AutoSize = true;
            this.lblCaptionRecipeStatus.Location = new System.Drawing.Point(3, 287);
            this.lblCaptionRecipeStatus.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            this.lblCaptionRecipeStatus.Size = new System.Drawing.Size(52, 21);
            this.lblCaptionRecipeStatus.TabIndex = 7;
            this.lblCaptionRecipeStatus.Text = "Status";
            // 
            // txtCalories
            // 
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Location = new System.Drawing.Point(111, 123);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(324, 29);
            this.txtCalories.TabIndex = 9;
            // 
            // txtDraftDate
            // 
            this.txtDraftDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDraftDate.Location = new System.Drawing.Point(111, 163);
            this.txtDraftDate.Name = "txtDraftDate";
            this.txtDraftDate.Size = new System.Drawing.Size(324, 29);
            this.txtDraftDate.TabIndex = 10;
            // 
            // txtPublishDate
            // 
            this.txtPublishDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPublishDate.Location = new System.Drawing.Point(111, 203);
            this.txtPublishDate.Name = "txtPublishDate";
            this.txtPublishDate.Size = new System.Drawing.Size(324, 29);
            this.txtPublishDate.TabIndex = 11;
            // 
            // txtArchiveDate
            // 
            this.txtArchiveDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArchiveDate.Location = new System.Drawing.Point(111, 243);
            this.txtArchiveDate.Name = "txtArchiveDate";
            this.txtArchiveDate.Size = new System.Drawing.Size(324, 29);
            this.txtArchiveDate.TabIndex = 12;
            // 
            // txtStatus
            // 
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatus.Location = new System.Drawing.Point(111, 283);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(324, 29);
            this.txtStatus.TabIndex = 13;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Location = new System.Drawing.Point(111, 83);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(324, 29);
            this.txtRecipeName.TabIndex = 18;
            // 
            // lblCaptionUserName
            // 
            this.lblCaptionUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionUserName.AutoSize = true;
            this.lblCaptionUserName.Location = new System.Drawing.Point(3, 9);
            this.lblCaptionUserName.Name = "lblCaptionUserName";
            this.lblCaptionUserName.Size = new System.Drawing.Size(84, 21);
            this.lblCaptionUserName.TabIndex = 1;
            this.lblCaptionUserName.Text = "UserName";
            // 
            // lblCaptionCuisineType
            // 
            this.lblCaptionCuisineType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCuisineType.AutoSize = true;
            this.lblCaptionCuisineType.Location = new System.Drawing.Point(3, 49);
            this.lblCaptionCuisineType.Name = "lblCaptionCuisineType";
            this.lblCaptionCuisineType.Size = new System.Drawing.Size(97, 21);
            this.lblCaptionCuisineType.TabIndex = 2;
            this.lblCaptionCuisineType.Text = "Cuisine Type";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserName.Location = new System.Drawing.Point(111, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(324, 40);
            this.lblUserName.TabIndex = 19;
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCuisineType
            // 
            this.lblCuisineType.AutoSize = true;
            this.lblCuisineType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCuisineType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCuisineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCuisineType.Location = new System.Drawing.Point(111, 40);
            this.lblCuisineType.Name = "lblCuisineType";
            this.lblCuisineType.Size = new System.Drawing.Size(324, 40);
            this.lblCuisineType.TabIndex = 20;
            this.lblCuisineType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 322);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecipe";
            this.Text = "Recipe";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblCaptionCalories;
        private Label lblCaptionRecipeName;
        private Label lblCaptionDraftDate;
        private Label lblCaptionPublishDate;
        private Label lblCaptionArchiveDate;
        private Label lblCaptionRecipeStatus;
        private TextBox txtCalories;
        private TextBox txtDraftDate;
        private TextBox txtPublishDate;
        private TextBox txtArchiveDate;
        private TextBox txtStatus;
        private TextBox txtRecipeName;
        private Label lblCaptionUserName;
        private Label lblCaptionCuisineType;
        private Label lblUserName;
        private Label lblCuisineType;
    }
}