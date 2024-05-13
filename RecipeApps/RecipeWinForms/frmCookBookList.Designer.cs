namespace RecipeWinForms
{
    partial class frmCookBookList
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
            this.btnNewCookBook = new System.Windows.Forms.Button();
            this.gCookBooks = new System.Windows.Forms.DataGridView();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCookBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Controls.Add(this.btnNewCookBook, 0, 0);
            this.tblMain.Controls.Add(this.gCookBooks, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(800, 450);
            this.tblMain.TabIndex = 0;
            // 
            // btnNewCookBook
            // 
            this.btnNewCookBook.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNewCookBook.BackColor = System.Drawing.Color.Lavender;
            this.btnNewCookBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewCookBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewCookBook.Location = new System.Drawing.Point(3, 3);
            this.btnNewCookBook.Name = "btnNewCookBook";
            this.btnNewCookBook.Size = new System.Drawing.Size(102, 24);
            this.btnNewCookBook.TabIndex = 1;
            this.btnNewCookBook.Text = "New CookBook";
            this.btnNewCookBook.UseVisualStyleBackColor = false;
            // 
            // gCookBooks
            // 
            this.gCookBooks.AllowUserToAddRows = false;
            this.gCookBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gCookBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCookBooks.Location = new System.Drawing.Point(3, 33);
            this.gCookBooks.Name = "gCookBooks";
            this.gCookBooks.RowTemplate.Height = 25;
            this.gCookBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gCookBooks.Size = new System.Drawing.Size(794, 414);
            this.gCookBooks.TabIndex = 0;
            // 
            // frmCookBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblMain);
            this.Name = "frmCookBookList";
            this.Text = "CookBook List";
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCookBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnNewCookBook;
        private DataGridView gCookBooks;
    }
}