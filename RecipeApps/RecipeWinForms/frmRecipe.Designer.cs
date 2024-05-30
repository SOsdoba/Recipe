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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblCuisine = new System.Windows.Forms.Label();
            this.lstCuisineType = new System.Windows.Forms.ComboBox();
            this.lblCalories = new System.Windows.Forms.Label();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.txtRecipeStatus = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtArchiveDate = new System.Windows.Forms.TextBox();
            this.lblDrafted = new System.Windows.Forms.Label();
            this.lblPublished = new System.Windows.Forms.Label();
            this.lblArchived = new System.Windows.Forms.Label();
            this.txtDraftDate = new System.Windows.Forms.TextBox();
            this.txtPublishDate = new System.Windows.Forms.TextBox();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tbIngredients = new System.Windows.Forms.TabPage();
            this.gIngredients = new System.Windows.Forms.DataGridView();
            this.tsIngredients = new System.Windows.Forms.ToolStrip();
            this.btnSaveIngredient = new System.Windows.Forms.ToolStripButton();
            this.tbSteps = new System.Windows.Forms.TabPage();
            this.gSteps = new System.Windows.Forms.DataGridView();
            this.tsSteps = new System.Windows.Forms.ToolStrip();
            this.btnSaveSteps = new System.Windows.Forms.ToolStripButton();
            this.lblStatusDates = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lstUserName = new System.Windows.Forms.ComboBox();
            this.tsButtonControls = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnChangeStatus = new System.Windows.Forms.ToolStripButton();
            this.tblMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.tbIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIngredients)).BeginInit();
            this.tsIngredients.SuspendLayout();
            this.tbSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSteps)).BeginInit();
            this.tsSteps.SuspendLayout();
            this.tsButtonControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.lblRecipeName, 0, 0);
            this.tblMain.Controls.Add(this.lblUser, 0, 1);
            this.tblMain.Controls.Add(this.txtRecipeName, 1, 0);
            this.tblMain.Controls.Add(this.lblCuisine, 0, 2);
            this.tblMain.Controls.Add(this.lstCuisineType, 1, 2);
            this.tblMain.Controls.Add(this.lblCalories, 0, 3);
            this.tblMain.Controls.Add(this.txtCalories, 1, 3);
            this.tblMain.Controls.Add(this.txtRecipeStatus, 1, 4);
            this.tblMain.Controls.Add(this.tableLayoutPanel1, 1, 5);
            this.tblMain.Controls.Add(this.tbMain, 0, 6);
            this.tblMain.Controls.Add(this.lblStatusDates, 0, 5);
            this.tblMain.Controls.Add(this.lblCurrentStatus, 0, 4);
            this.tblMain.Controls.Add(this.lstUserName, 1, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 41);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 7;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(590, 611);
            this.tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Location = new System.Drawing.Point(15, 13);
            this.lblRecipeName.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(102, 21);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "Recipe Name";
            this.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(15, 61);
            this.lblUser.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 21);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeName.Location = new System.Drawing.Point(123, 0);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(0);
            this.txtRecipeName.Multiline = true;
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(467, 48);
            this.txtRecipeName.TabIndex = 1;
            // 
            // lblCuisine
            // 
            this.lblCuisine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuisine.AutoSize = true;
            this.lblCuisine.Location = new System.Drawing.Point(15, 109);
            this.lblCuisine.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblCuisine.Name = "lblCuisine";
            this.lblCuisine.Size = new System.Drawing.Size(61, 21);
            this.lblCuisine.TabIndex = 4;
            this.lblCuisine.Text = "Cuisine";
            this.lblCuisine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstCuisineType
            // 
            this.lstCuisineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCuisineType.DropDownHeight = 150;
            this.lstCuisineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCuisineType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstCuisineType.FormattingEnabled = true;
            this.lstCuisineType.IntegralHeight = false;
            this.lstCuisineType.ItemHeight = 21;
            this.lstCuisineType.Location = new System.Drawing.Point(123, 96);
            this.lstCuisineType.Margin = new System.Windows.Forms.Padding(0);
            this.lstCuisineType.Name = "lstCuisineType";
            this.lstCuisineType.Size = new System.Drawing.Size(467, 29);
            this.lstCuisineType.TabIndex = 5;
            // 
            // lblCalories
            // 
            this.lblCalories.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(15, 157);
            this.lblCalories.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(105, 21);
            this.lblCalories.TabIndex = 6;
            this.lblCalories.Text = "Num Calories";
            this.lblCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCalories
            // 
            this.txtCalories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCalories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCalories.Location = new System.Drawing.Point(123, 144);
            this.txtCalories.Margin = new System.Windows.Forms.Padding(0);
            this.txtCalories.Multiline = true;
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(467, 48);
            this.txtCalories.TabIndex = 7;
            // 
            // txtRecipeStatus
            // 
            this.txtRecipeStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecipeStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtRecipeStatus.Enabled = false;
            this.txtRecipeStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeStatus.Location = new System.Drawing.Point(123, 202);
            this.txtRecipeStatus.Margin = new System.Windows.Forms.Padding(0);
            this.txtRecipeStatus.Multiline = true;
            this.txtRecipeStatus.Name = "txtRecipeStatus";
            this.txtRecipeStatus.ReadOnly = true;
            this.txtRecipeStatus.Size = new System.Drawing.Size(467, 28);
            this.txtRecipeStatus.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.txtArchiveDate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDrafted, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPublished, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblArchived, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDraftDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPublishDate, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(126, 243);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 55);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // txtArchiveDate
            // 
            this.txtArchiveDate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtArchiveDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArchiveDate.Enabled = false;
            this.txtArchiveDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtArchiveDate.Location = new System.Drawing.Point(306, 21);
            this.txtArchiveDate.Margin = new System.Windows.Forms.Padding(0);
            this.txtArchiveDate.Multiline = true;
            this.txtArchiveDate.Name = "txtArchiveDate";
            this.txtArchiveDate.ReadOnly = true;
            this.txtArchiveDate.Size = new System.Drawing.Size(155, 63);
            this.txtArchiveDate.TabIndex = 5;
            // 
            // lblDrafted
            // 
            this.lblDrafted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrafted.AutoSize = true;
            this.lblDrafted.Location = new System.Drawing.Point(3, 0);
            this.lblDrafted.Name = "lblDrafted";
            this.lblDrafted.Size = new System.Drawing.Size(147, 21);
            this.lblDrafted.TabIndex = 2;
            this.lblDrafted.Text = "Drafted";
            this.lblDrafted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            this.lblPublished.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPublished.AutoSize = true;
            this.lblPublished.Location = new System.Drawing.Point(156, 0);
            this.lblPublished.Name = "lblPublished";
            this.lblPublished.Size = new System.Drawing.Size(147, 21);
            this.lblPublished.TabIndex = 2;
            this.lblPublished.Text = "Published";
            this.lblPublished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            this.lblArchived.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArchived.AutoSize = true;
            this.lblArchived.Location = new System.Drawing.Point(309, 0);
            this.lblArchived.Name = "lblArchived";
            this.lblArchived.Size = new System.Drawing.Size(149, 21);
            this.lblArchived.TabIndex = 4;
            this.lblArchived.Text = "Archived";
            this.lblArchived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDraftDate
            // 
            this.txtDraftDate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtDraftDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDraftDate.Enabled = false;
            this.txtDraftDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDraftDate.Location = new System.Drawing.Point(0, 21);
            this.txtDraftDate.Margin = new System.Windows.Forms.Padding(0);
            this.txtDraftDate.Multiline = true;
            this.txtDraftDate.Name = "txtDraftDate";
            this.txtDraftDate.ReadOnly = true;
            this.txtDraftDate.Size = new System.Drawing.Size(153, 63);
            this.txtDraftDate.TabIndex = 1;
            // 
            // txtPublishDate
            // 
            this.txtPublishDate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtPublishDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPublishDate.Enabled = false;
            this.txtPublishDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPublishDate.Location = new System.Drawing.Point(153, 21);
            this.txtPublishDate.Margin = new System.Windows.Forms.Padding(0);
            this.txtPublishDate.Multiline = true;
            this.txtPublishDate.Name = "txtPublishDate";
            this.txtPublishDate.ReadOnly = true;
            this.txtPublishDate.Size = new System.Drawing.Size(153, 63);
            this.txtPublishDate.TabIndex = 3;
            // 
            // tbMain
            // 
            this.tblMain.SetColumnSpan(this.tbMain, 2);
            this.tbMain.Controls.Add(this.tbIngredients);
            this.tbMain.Controls.Add(this.tbSteps);
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMain.Location = new System.Drawing.Point(3, 304);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(584, 304);
            this.tbMain.TabIndex = 12;
            // 
            // tbIngredients
            // 
            this.tbIngredients.Controls.Add(this.gIngredients);
            this.tbIngredients.Controls.Add(this.tsIngredients);
            this.tbIngredients.Location = new System.Drawing.Point(4, 30);
            this.tbIngredients.Name = "tbIngredients";
            this.tbIngredients.Padding = new System.Windows.Forms.Padding(3);
            this.tbIngredients.Size = new System.Drawing.Size(576, 270);
            this.tbIngredients.TabIndex = 0;
            this.tbIngredients.Text = "Ingredients";
            this.tbIngredients.UseVisualStyleBackColor = true;
            // 
            // gIngredients
            // 
            this.gIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gIngredients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gIngredients.Location = new System.Drawing.Point(3, 28);
            this.gIngredients.Name = "gIngredients";
            this.gIngredients.RowTemplate.Height = 25;
            this.gIngredients.Size = new System.Drawing.Size(570, 239);
            this.gIngredients.TabIndex = 1;
            // 
            // tsIngredients
            // 
            this.tsIngredients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveIngredient});
            this.tsIngredients.Location = new System.Drawing.Point(3, 3);
            this.tsIngredients.Name = "tsIngredients";
            this.tsIngredients.Size = new System.Drawing.Size(570, 25);
            this.tsIngredients.TabIndex = 0;
            this.tsIngredients.Text = "toolStrip1";
            // 
            // btnSaveIngredient
            // 
            this.btnSaveIngredient.BackColor = System.Drawing.Color.LightGray;
            this.btnSaveIngredient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveIngredient.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveIngredient.Image")));
            this.btnSaveIngredient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveIngredient.Name = "btnSaveIngredient";
            this.btnSaveIngredient.Size = new System.Drawing.Size(35, 22);
            this.btnSaveIngredient.Text = "Save";
            // 
            // tbSteps
            // 
            this.tbSteps.Controls.Add(this.gSteps);
            this.tbSteps.Controls.Add(this.tsSteps);
            this.tbSteps.Location = new System.Drawing.Point(4, 24);
            this.tbSteps.Name = "tbSteps";
            this.tbSteps.Padding = new System.Windows.Forms.Padding(3);
            this.tbSteps.Size = new System.Drawing.Size(576, 276);
            this.tbSteps.TabIndex = 1;
            this.tbSteps.Text = "Steps";
            this.tbSteps.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            this.gSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gSteps.Location = new System.Drawing.Point(3, 28);
            this.gSteps.Name = "gSteps";
            this.gSteps.RowTemplate.Height = 25;
            this.gSteps.Size = new System.Drawing.Size(570, 245);
            this.gSteps.TabIndex = 1;
            // 
            // tsSteps
            // 
            this.tsSteps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveSteps});
            this.tsSteps.Location = new System.Drawing.Point(3, 3);
            this.tsSteps.Name = "tsSteps";
            this.tsSteps.Size = new System.Drawing.Size(570, 25);
            this.tsSteps.TabIndex = 0;
            this.tsSteps.Text = "toolStrip1";
            // 
            // btnSaveSteps
            // 
            this.btnSaveSteps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveSteps.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveSteps.Image")));
            this.btnSaveSteps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveSteps.Name = "btnSaveSteps";
            this.btnSaveSteps.Size = new System.Drawing.Size(35, 22);
            this.btnSaveSteps.Text = "Save";
            // 
            // lblStatusDates
            // 
            this.lblStatusDates.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusDates.AutoSize = true;
            this.lblStatusDates.Location = new System.Drawing.Point(15, 260);
            this.lblStatusDates.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblStatusDates.Name = "lblStatusDates";
            this.lblStatusDates.Size = new System.Drawing.Size(95, 21);
            this.lblStatusDates.TabIndex = 10;
            this.lblStatusDates.Text = "Status Dates";
            this.lblStatusDates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Location = new System.Drawing.Point(3, 192);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(109, 48);
            this.lblCurrentStatus.TabIndex = 8;
            this.lblCurrentStatus.Text = "Current Status";
            this.lblCurrentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstUserName
            // 
            this.lstUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUserName.DropDownHeight = 100;
            this.lstUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstUserName.FormattingEnabled = true;
            this.lstUserName.IntegralHeight = false;
            this.lstUserName.ItemHeight = 21;
            this.lstUserName.Location = new System.Drawing.Point(123, 48);
            this.lstUserName.Margin = new System.Windows.Forms.Padding(0);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(467, 29);
            this.lstUserName.TabIndex = 3;
            // 
            // tsButtonControls
            // 
            this.tsButtonControls.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsButtonControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.toolStripSeparator1,
            this.btnDelete,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.btnChangeStatus});
            this.tsButtonControls.Location = new System.Drawing.Point(0, 0);
            this.tsButtonControls.Name = "tsButtonControls";
            this.tsButtonControls.Padding = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.tsButtonControls.Size = new System.Drawing.Size(590, 41);
            this.tsButtonControls.TabIndex = 1;
            this.tsButtonControls.TabStop = true;
            this.tsButtonControls.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 35);
            this.btnSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(15, 38);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 35);
            this.btnDelete.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnChangeStatus.AutoSize = false;
            this.btnChangeStatus.BackColor = System.Drawing.Color.LightGray;
            this.btnChangeStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnChangeStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeStatus.Image")));
            this.btnChangeStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(115, 35);
            this.btnChangeStatus.Text = "Change Status...";
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(590, 652);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.tsButtonControls);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecipe";
            this.Text = "Recipe";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tbMain.ResumeLayout(false);
            this.tbIngredients.ResumeLayout(false);
            this.tbIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIngredients)).EndInit();
            this.tsIngredients.ResumeLayout(false);
            this.tsIngredients.PerformLayout();
            this.tbSteps.ResumeLayout(false);
            this.tbSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSteps)).EndInit();
            this.tsSteps.ResumeLayout(false);
            this.tsSteps.PerformLayout();
            this.tsButtonControls.ResumeLayout(false);
            this.tsButtonControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCalories;
        private Label lblCuisine;
        private Label lblStatusDates;
        private TextBox txtCalories;
        private TextBox txtDraftDate;
        private TextBox txtPublishDate;
        private TextBox txtArchiveDate;
        private TextBox txtRecipeStatus;
        private TextBox txtRecipeName;
        private Label lblRecipeName;
        private Label lblUser;
        private ToolStrip tsButtonControls;
        private ToolStripButton btnSave;
        private ToolStripButton btnDelete;
        private ComboBox lstCuisineType;
        private ComboBox lstUserName;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnChangeStatus;
        private ToolStripSeparator toolStripSeparator3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private TabControl tbMain;
        private TabPage tbIngredients;
        private TabPage tbSteps;
        private Label lblCurrentStatus;
        private DataGridView gIngredients;
        private ToolStrip tsIngredients;
        private ToolStripButton btnSaveIngredient;
        private DataGridView gSteps;
        private ToolStrip tsSteps;
        private ToolStripButton btnSaveSteps;
    }
}