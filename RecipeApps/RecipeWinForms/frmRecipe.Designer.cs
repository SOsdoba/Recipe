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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
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
            this.txtRecipeStatus = new System.Windows.Forms.TextBox();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblCaptionUserName = new System.Windows.Forms.Label();
            this.lblCaptionCuisineType = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.lstCuisineType = new System.Windows.Forms.ComboBox();
            this.lstUserName = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.tableLayoutPanel1.Controls.Add(this.txtRecipeStatus, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtRecipeName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCaptionUserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCaptionCuisineType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lstCuisineType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstUserName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(438, 356);
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
            // txtRecipeStatus
            // 
            this.txtRecipeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeStatus.Location = new System.Drawing.Point(111, 283);
            this.txtRecipeStatus.Name = "txtRecipeStatus";
            this.txtRecipeStatus.ReadOnly = true;
            this.txtRecipeStatus.Size = new System.Drawing.Size(324, 29);
            this.txtRecipeStatus.TabIndex = 13;
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.toolStripSeparator1,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 320);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(108, 36);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(35, 33);
            this.btnSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 33);
            this.btnDelete.Text = "Delete";
            // 
            // lstCuisineType
            // 
            this.lstCuisineType.FormattingEnabled = true;
            this.lstCuisineType.Location = new System.Drawing.Point(111, 43);
            this.lstCuisineType.Name = "lstCuisineType";
            this.lstCuisineType.Size = new System.Drawing.Size(121, 29);
            this.lstCuisineType.TabIndex = 22;
            // 
            // lstUserName
            // 
            this.lstUserName.FormattingEnabled = true;
            this.lstUserName.Location = new System.Drawing.Point(111, 3);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(121, 29);
            this.lstUserName.TabIndex = 23;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 359);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecipe";
            this.Text = "Recipe";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private TextBox txtRecipeStatus;
        private TextBox txtRecipeName;
        private Label lblCaptionUserName;
        private Label lblCaptionCuisineType;
        private ToolStrip toolStrip1;
        private ToolStripButton btnSave;
        private ToolStripButton btnDelete;
        private ComboBox lstCuisineType;
        private ComboBox lstUserName;
        private ToolStripSeparator toolStripSeparator1;
    }
}