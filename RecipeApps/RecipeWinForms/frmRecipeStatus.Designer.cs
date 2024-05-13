namespace RecipeWinForms
{
    partial class frmRecipeStatus
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
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRecipeStatus = new System.Windows.Forms.Label();
            this.btnDraft = new System.Windows.Forms.Button();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDrafted = new System.Windows.Forms.Label();
            this.lblPublished = new System.Windows.Forms.Label();
            this.lblArchived = new System.Windows.Forms.Label();
            this.lblStatusDates = new System.Windows.Forms.Label();
            this.txtDraftDate = new System.Windows.Forms.TextBox();
            this.txtPublishDate = new System.Windows.Forms.TextBox();
            this.txtArchiveDate = new System.Windows.Forms.TextBox();
            this.tblMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.Controls.Add(this.lblRecipeName, 0, 0);
            this.tblMain.Controls.Add(this.lblStatus, 0, 1);
            this.tblMain.Controls.Add(this.lblRecipeStatus, 1, 1);
            this.tblMain.Controls.Add(this.btnDraft, 0, 4);
            this.tblMain.Controls.Add(this.btnPublish, 1, 4);
            this.tblMain.Controls.Add(this.btnArchive, 2, 4);
            this.tblMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 5;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblMain.Size = new System.Drawing.Size(600, 455);
            this.tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.tblMain.SetColumnSpan(this.lblRecipeName, 3);
            this.lblRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeName.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecipeName.Location = new System.Drawing.Point(3, 0);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(594, 113);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "Recipe Name";
            this.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(3, 113);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(193, 68);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Current Status: ";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRecipeStatus
            // 
            this.lblRecipeStatus.AutoSize = true;
            this.lblRecipeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeStatus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecipeStatus.Location = new System.Drawing.Point(202, 113);
            this.lblRecipeStatus.Name = "lblRecipeStatus";
            this.lblRecipeStatus.Size = new System.Drawing.Size(193, 68);
            this.lblRecipeStatus.TabIndex = 2;
            this.lblRecipeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDraft
            // 
            this.btnDraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDraft.Location = new System.Drawing.Point(121, 297);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.Size = new System.Drawing.Size(75, 23);
            this.btnDraft.TabIndex = 3;
            this.btnDraft.Text = "Draft";
            this.btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            this.btnPublish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPublish.Location = new System.Drawing.Point(261, 297);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(75, 23);
            this.btnPublish.TabIndex = 4;
            this.btnPublish.Text = "Publish";
            this.btnPublish.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(401, 297);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(75, 23);
            this.btnArchive.TabIndex = 5;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tblMain.SetColumnSpan(this.tableLayoutPanel1, 3);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblDrafted, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPublished, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblArchived, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStatusDates, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDraftDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPublishDate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtArchiveDate, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 184);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tblMain.SetRowSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(594, 107);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblDrafted
            // 
            this.lblDrafted.AutoSize = true;
            this.lblDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDrafted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDrafted.Location = new System.Drawing.Point(151, 0);
            this.lblDrafted.Name = "lblDrafted";
            this.lblDrafted.Size = new System.Drawing.Size(142, 37);
            this.lblDrafted.TabIndex = 0;
            this.lblDrafted.Text = "Drafted";
            this.lblDrafted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            this.lblPublished.AutoSize = true;
            this.lblPublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPublished.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPublished.Location = new System.Drawing.Point(299, 0);
            this.lblPublished.Name = "lblPublished";
            this.lblPublished.Size = new System.Drawing.Size(142, 37);
            this.lblPublished.TabIndex = 1;
            this.lblPublished.Text = "Published";
            this.lblPublished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            this.lblArchived.AutoSize = true;
            this.lblArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArchived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArchived.Location = new System.Drawing.Point(447, 0);
            this.lblArchived.Name = "lblArchived";
            this.lblArchived.Size = new System.Drawing.Size(144, 37);
            this.lblArchived.TabIndex = 2;
            this.lblArchived.Text = "Archived";
            this.lblArchived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusDates
            // 
            this.lblStatusDates.AutoSize = true;
            this.lblStatusDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusDates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatusDates.Location = new System.Drawing.Point(3, 37);
            this.lblStatusDates.Name = "lblStatusDates";
            this.lblStatusDates.Size = new System.Drawing.Size(142, 70);
            this.lblStatusDates.TabIndex = 3;
            this.lblStatusDates.Text = "StatusDates";
            this.lblStatusDates.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDraftDate
            // 
            this.txtDraftDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDraftDate.Location = new System.Drawing.Point(172, 60);
            this.txtDraftDate.Name = "txtDraftDate";
            this.txtDraftDate.ReadOnly = true;
            this.txtDraftDate.Size = new System.Drawing.Size(100, 23);
            this.txtDraftDate.TabIndex = 4;
            // 
            // txtPublishDate
            // 
            this.txtPublishDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPublishDate.Location = new System.Drawing.Point(320, 60);
            this.txtPublishDate.Name = "txtPublishDate";
            this.txtPublishDate.ReadOnly = true;
            this.txtPublishDate.Size = new System.Drawing.Size(100, 23);
            this.txtPublishDate.TabIndex = 5;
            // 
            // txtArchiveDate
            // 
            this.txtArchiveDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtArchiveDate.Location = new System.Drawing.Point(469, 60);
            this.txtArchiveDate.Name = "txtArchiveDate";
            this.txtArchiveDate.ReadOnly = true;
            this.txtArchiveDate.Size = new System.Drawing.Size(100, 23);
            this.txtArchiveDate.TabIndex = 6;
            // 
            // frmRecipeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 455);
            this.Controls.Add(this.tblMain);
            this.Name = "frmRecipeStatus";
            this.Text = "Recipe - Change Status";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblStatus;
        private Label lblRecipeStatus;
        private Button btnDraft;
        private Button btnPublish;
        private Button btnArchive;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private Label lblStatusDates;
        private TextBox txtDraftDate;
        private TextBox txtPublishDate;
        private TextBox txtArchiveDate;
    }
}