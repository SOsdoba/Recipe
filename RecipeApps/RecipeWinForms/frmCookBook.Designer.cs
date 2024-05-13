namespace RecipeWinForms
{
    partial class frmCookBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCookBook));
            this.chkCookBookActive = new System.Windows.Forms.CheckBox();
            this.txtDateBookCreated = new System.Windows.Forms.TextBox();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCookBookName = new System.Windows.Forms.TextBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCookBookName = new System.Windows.Forms.Label();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnSaveCookBook = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteCookBook = new System.Windows.Forms.ToolStripButton();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tsControls = new System.Windows.Forms.ToolStrip();
            this.tsRecipeControls = new System.Windows.Forms.ToolStrip();
            this.btnSaveCookBookRecipes = new System.Windows.Forms.ToolStripButton();
            this.gCookBookRecipes = new System.Windows.Forms.DataGridView();
            this.lstUserName = new System.Windows.Forms.ComboBox();
            this.tblMain.SuspendLayout();
            this.tsControls.SuspendLayout();
            this.tsRecipeControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCookBookRecipes)).BeginInit();
            this.SuspendLayout();
            // 
            // chkCookBookActive
            // 
            this.chkCookBookActive.AutoSize = true;
            this.chkCookBookActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkCookBookActive.Location = new System.Drawing.Point(273, 156);
            this.chkCookBookActive.Name = "chkCookBookActive";
            this.chkCookBookActive.Size = new System.Drawing.Size(264, 15);
            this.chkCookBookActive.TabIndex = 10;
            this.chkCookBookActive.UseVisualStyleBackColor = true;
            // 
            // txtDateBookCreated
            // 
            this.txtDateBookCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateBookCreated.Enabled = false;
            this.txtDateBookCreated.Location = new System.Drawing.Point(543, 121);
            this.txtDateBookCreated.Name = "txtDateBookCreated";
            this.txtDateBookCreated.Size = new System.Drawing.Size(266, 29);
            this.txtDateBookCreated.TabIndex = 8;
            this.txtDateBookCreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateCreated.Location = new System.Drawing.Point(543, 97);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(266, 21);
            this.lblDateCreated.TabIndex = 7;
            this.lblDateCreated.Text = "Date created:";
            this.lblDateCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtPrice.Location = new System.Drawing.Point(273, 121);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(174, 29);
            this.txtPrice.TabIndex = 6;
            // 
            // txtCookBookName
            // 
            this.tblMain.SetColumnSpan(this.txtCookBookName, 2);
            this.txtCookBookName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCookBookName.Location = new System.Drawing.Point(273, 36);
            this.txtCookBookName.Name = "txtCookBookName";
            this.txtCookBookName.Size = new System.Drawing.Size(536, 29);
            this.txtCookBookName.TabIndex = 2;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActive.Location = new System.Drawing.Point(3, 153);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(264, 21);
            this.lblActive.TabIndex = 9;
            this.lblActive.Text = "Active";
            this.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Location = new System.Drawing.Point(3, 118);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(264, 35);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthor.Location = new System.Drawing.Point(3, 68);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(264, 29);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCookBookName
            // 
            this.lblCookBookName.AutoSize = true;
            this.lblCookBookName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCookBookName.Location = new System.Drawing.Point(3, 33);
            this.lblCookBookName.Name = "lblCookBookName";
            this.lblCookBookName.Size = new System.Drawing.Size(264, 35);
            this.lblCookBookName.TabIndex = 1;
            this.lblCookBookName.Text = "CookBook Name";
            this.lblCookBookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(120, 8);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(812, 79);
            this.miniToolStrip.TabIndex = 1;
            // 
            // btnSaveCookBook
            // 
            this.btnSaveCookBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveCookBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveCookBook.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCookBook.Image")));
            this.btnSaveCookBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveCookBook.Name = "btnSaveCookBook";
            this.btnSaveCookBook.Size = new System.Drawing.Size(47, 30);
            this.btnSaveCookBook.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // btnDeleteCookBook
            // 
            this.btnDeleteCookBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteCookBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCookBook.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCookBook.Image")));
            this.btnDeleteCookBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCookBook.Name = "btnDeleteCookBook";
            this.btnDeleteCookBook.Size = new System.Drawing.Size(58, 30);
            this.btnDeleteCookBook.Text = "Delete";
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblMain.Controls.Add(this.tsControls, 0, 0);
            this.tblMain.Controls.Add(this.lblCookBookName, 0, 1);
            this.tblMain.Controls.Add(this.lblAuthor, 0, 2);
            this.tblMain.Controls.Add(this.lblPrice, 0, 4);
            this.tblMain.Controls.Add(this.lblActive, 0, 5);
            this.tblMain.Controls.Add(this.txtCookBookName, 1, 1);
            this.tblMain.Controls.Add(this.txtPrice, 1, 4);
            this.tblMain.Controls.Add(this.lblDateCreated, 2, 3);
            this.tblMain.Controls.Add(this.txtDateBookCreated, 2, 4);
            this.tblMain.Controls.Add(this.chkCookBookActive, 1, 5);
            this.tblMain.Controls.Add(this.tsRecipeControls, 0, 6);
            this.tblMain.Controls.Add(this.gCookBookRecipes, 0, 7);
            this.tblMain.Controls.Add(this.lstUserName, 1, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 8;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.61539F));
            this.tblMain.Size = new System.Drawing.Size(812, 386);
            this.tblMain.TabIndex = 0;
            // 
            // tsControls
            // 
            this.tblMain.SetColumnSpan(this.tsControls, 3);
            this.tsControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveCookBook,
            this.toolStripSeparator1,
            this.btnDeleteCookBook});
            this.tsControls.Location = new System.Drawing.Point(0, 0);
            this.tsControls.Name = "tsControls";
            this.tsControls.Size = new System.Drawing.Size(812, 33);
            this.tsControls.TabIndex = 0;
            // 
            // tsRecipeControls
            // 
            this.tblMain.SetColumnSpan(this.tsRecipeControls, 3);
            this.tsRecipeControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsRecipeControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveCookBookRecipes});
            this.tsRecipeControls.Location = new System.Drawing.Point(0, 174);
            this.tsRecipeControls.Name = "tsRecipeControls";
            this.tsRecipeControls.Size = new System.Drawing.Size(812, 28);
            this.tsRecipeControls.TabIndex = 11;
            this.tsRecipeControls.TabStop = true;
            this.tsRecipeControls.Text = "toolStrip1";
            // 
            // btnSaveCookBookRecipes
            // 
            this.btnSaveCookBookRecipes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveCookBookRecipes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveCookBookRecipes.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCookBookRecipes.Image")));
            this.btnSaveCookBookRecipes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveCookBookRecipes.Name = "btnSaveCookBookRecipes";
            this.btnSaveCookBookRecipes.Size = new System.Drawing.Size(47, 25);
            this.btnSaveCookBookRecipes.Text = "Save";
            // 
            // gCookBookRecipes
            // 
            this.gCookBookRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMain.SetColumnSpan(this.gCookBookRecipes, 3);
            this.gCookBookRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCookBookRecipes.Location = new System.Drawing.Point(3, 205);
            this.gCookBookRecipes.Name = "gCookBookRecipes";
            this.gCookBookRecipes.RowTemplate.Height = 25;
            this.gCookBookRecipes.Size = new System.Drawing.Size(806, 178);
            this.gCookBookRecipes.TabIndex = 12;
            // 
            // lstUserName
            // 
            this.tblMain.SetColumnSpan(this.lstUserName, 2);
            this.lstUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUserName.FormattingEnabled = true;
            this.lstUserName.Location = new System.Drawing.Point(273, 71);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(536, 29);
            this.lstUserName.TabIndex = 4;
            // 
            // frmCookBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 386);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCookBook";
            this.Text = "CookBook";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tsControls.ResumeLayout(false);
            this.tsControls.PerformLayout();
            this.tsRecipeControls.ResumeLayout(false);
            this.tsRecipeControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCookBookRecipes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CheckBox chkCookBookActive;
        private TextBox txtDateBookCreated;
        private Label lblDateCreated;
        private TextBox txtPrice;
        private TableLayoutPanel tblMain;
        private ToolStrip tsControls;
        private ToolStripButton btnSaveCookBook;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDeleteCookBook;
        private Label lblCookBookName;
        private Label lblAuthor;
        private Label lblPrice;
        private Label lblActive;
        private TextBox txtCookBookName;
        private ToolStrip tsRecipeControls;
        private ToolStripButton btnSaveCookBookRecipes;
        private DataGridView gCookBookRecipes;
        private ToolStrip miniToolStrip;
        private ComboBox lstUserName;
    }
}