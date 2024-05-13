namespace RecipeWinForms
{
    partial class frmMealList
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
            this.gMeals = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gMeals)).BeginInit();
            this.SuspendLayout();
            // 
            // gMeals
            // 
            this.gMeals.AllowUserToAddRows = false;
            this.gMeals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gMeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMeals.Location = new System.Drawing.Point(0, 0);
            this.gMeals.Name = "gMeals";
            this.gMeals.RowTemplate.Height = 25;
            this.gMeals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gMeals.Size = new System.Drawing.Size(800, 450);
            this.gMeals.TabIndex = 0;
            // 
            // frmMealList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gMeals);
            this.Name = "frmMealList";
            this.Text = "Meal List";
            ((System.ComponentModel.ISupportInitialize)(this.gMeals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView gMeals;
    }
}