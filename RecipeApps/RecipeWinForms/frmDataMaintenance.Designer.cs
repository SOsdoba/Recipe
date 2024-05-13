namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            this.pnlOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.optUsers = new System.Windows.Forms.RadioButton();
            this.optCuisines = new System.Windows.Forms.RadioButton();
            this.optIngredients = new System.Windows.Forms.RadioButton();
            this.optMeasurements = new System.Windows.Forms.RadioButton();
            this.optCourses = new System.Windows.Forms.RadioButton();
            this.gData = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.pnlOptions, 0, 0);
            this.tblMain.Controls.Add(this.gData, 1, 0);
            this.tblMain.Controls.Add(this.btnSave, 1, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(710, 444);
            this.tblMain.TabIndex = 0;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.optUsers);
            this.pnlOptions.Controls.Add(this.optCuisines);
            this.pnlOptions.Controls.Add(this.optIngredients);
            this.pnlOptions.Controls.Add(this.optMeasurements);
            this.pnlOptions.Controls.Add(this.optCourses);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlOptions.Location = new System.Drawing.Point(3, 3);
            this.pnlOptions.Name = "pnlOptions";
            this.tblMain.SetRowSpan(this.pnlOptions, 2);
            this.pnlOptions.Size = new System.Drawing.Size(200, 438);
            this.pnlOptions.TabIndex = 0;
            // 
            // optUsers
            // 
            this.optUsers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.optUsers.AutoSize = true;
            this.optUsers.Checked = true;
            this.optUsers.Location = new System.Drawing.Point(3, 3);
            this.optUsers.Name = "optUsers";
            this.optUsers.Size = new System.Drawing.Size(67, 25);
            this.optUsers.TabIndex = 0;
            this.optUsers.TabStop = true;
            this.optUsers.Text = "Users";
            this.optUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optUsers.UseVisualStyleBackColor = true;
            // 
            // optCuisines
            // 
            this.optCuisines.AutoSize = true;
            this.optCuisines.Location = new System.Drawing.Point(3, 34);
            this.optCuisines.Name = "optCuisines";
            this.optCuisines.Size = new System.Drawing.Size(86, 25);
            this.optCuisines.TabIndex = 1;
            this.optCuisines.Text = "Cuisines";
            this.optCuisines.UseVisualStyleBackColor = true;
            // 
            // optIngredients
            // 
            this.optIngredients.AutoSize = true;
            this.optIngredients.Location = new System.Drawing.Point(3, 65);
            this.optIngredients.Name = "optIngredients";
            this.optIngredients.Size = new System.Drawing.Size(106, 25);
            this.optIngredients.TabIndex = 2;
            this.optIngredients.Text = "Ingredients";
            this.optIngredients.UseVisualStyleBackColor = true;
            // 
            // optMeasurements
            // 
            this.optMeasurements.AutoSize = true;
            this.optMeasurements.Location = new System.Drawing.Point(3, 96);
            this.optMeasurements.Name = "optMeasurements";
            this.optMeasurements.Size = new System.Drawing.Size(131, 25);
            this.optMeasurements.TabIndex = 3;
            this.optMeasurements.Text = "Measurements";
            this.optMeasurements.UseVisualStyleBackColor = true;
            // 
            // optCourses
            // 
            this.optCourses.AutoSize = true;
            this.optCourses.Location = new System.Drawing.Point(3, 127);
            this.optCourses.Name = "optCourses";
            this.optCourses.Size = new System.Drawing.Size(84, 25);
            this.optCourses.TabIndex = 4;
            this.optCourses.Text = "Courses";
            this.optCourses.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            this.gData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gData.Location = new System.Drawing.Point(209, 3);
            this.gData.Name = "gData";
            this.gData.RowTemplate.Height = 25;
            this.gData.Size = new System.Drawing.Size(498, 385);
            this.gData.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(600, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 47);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // frmDataMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 444);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDataMaintenance";
            this.Text = "Data Maintenance";
            this.tblMain.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private FlowLayoutPanel pnlOptions;
        private RadioButton optUsers;
        private RadioButton optCuisines;
        private RadioButton optIngredients;
        private RadioButton optMeasurements;
        private RadioButton optCourses;
        private DataGridView gData;
        private Button btnSave;
    }
}