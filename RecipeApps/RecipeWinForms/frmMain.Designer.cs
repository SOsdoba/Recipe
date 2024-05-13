namespace RecipeWinForms
{
    partial class frmMain
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecipes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecipesList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewRecipe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloneARecipe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMeals = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMealsList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCookbooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCookbookList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewCookbook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAutoCreateCookbook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuRecipes,
            this.mnuMeals,
            this.mnuCookbooks,
            this.mnuDataMaintenance,
            this.mnuWindows});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1029, 29);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDashboard});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 25);
            this.mnuFile.Text = "File";
            // 
            // mnuDashboard
            // 
            this.mnuDashboard.Name = "mnuDashboard";
            this.mnuDashboard.Size = new System.Drawing.Size(156, 26);
            this.mnuDashboard.Text = "Dashboard";
            // 
            // mnuRecipes
            // 
            this.mnuRecipes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRecipesList,
            this.mnuNewRecipe,
            this.mnuCloneARecipe});
            this.mnuRecipes.Name = "mnuRecipes";
            this.mnuRecipes.Size = new System.Drawing.Size(75, 25);
            this.mnuRecipes.Text = "Recipes";
            // 
            // mnuRecipesList
            // 
            this.mnuRecipesList.Name = "mnuRecipesList";
            this.mnuRecipesList.Size = new System.Drawing.Size(182, 26);
            this.mnuRecipesList.Text = "List";
            // 
            // mnuNewRecipe
            // 
            this.mnuNewRecipe.Name = "mnuNewRecipe";
            this.mnuNewRecipe.Size = new System.Drawing.Size(182, 26);
            this.mnuNewRecipe.Text = "New Recipe";
            // 
            // mnuCloneARecipe
            // 
            this.mnuCloneARecipe.Name = "mnuCloneARecipe";
            this.mnuCloneARecipe.Size = new System.Drawing.Size(182, 26);
            this.mnuCloneARecipe.Text = "Clone a Recipe";
            // 
            // mnuMeals
            // 
            this.mnuMeals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMealsList});
            this.mnuMeals.Name = "mnuMeals";
            this.mnuMeals.Size = new System.Drawing.Size(63, 25);
            this.mnuMeals.Text = "Meals";
            // 
            // mnuMealsList
            // 
            this.mnuMealsList.Name = "mnuMealsList";
            this.mnuMealsList.Size = new System.Drawing.Size(104, 26);
            this.mnuMealsList.Text = "List";
            // 
            // mnuCookbooks
            // 
            this.mnuCookbooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCookbookList,
            this.mnuNewCookbook,
            this.mnuAutoCreateCookbook});
            this.mnuCookbooks.Name = "mnuCookbooks";
            this.mnuCookbooks.Size = new System.Drawing.Size(100, 25);
            this.mnuCookbooks.Text = "Cookbooks";
            // 
            // mnuCookbookList
            // 
            this.mnuCookbookList.Name = "mnuCookbookList";
            this.mnuCookbookList.Size = new System.Drawing.Size(187, 26);
            this.mnuCookbookList.Text = "List";
            // 
            // mnuNewCookbook
            // 
            this.mnuNewCookbook.Name = "mnuNewCookbook";
            this.mnuNewCookbook.Size = new System.Drawing.Size(187, 26);
            this.mnuNewCookbook.Text = "New Cookbook";
            // 
            // mnuAutoCreateCookbook
            // 
            this.mnuAutoCreateCookbook.Name = "mnuAutoCreateCookbook";
            this.mnuAutoCreateCookbook.Size = new System.Drawing.Size(187, 26);
            this.mnuAutoCreateCookbook.Text = "Auto-Create";
            // 
            // mnuDataMaintenance
            // 
            this.mnuDataMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditData});
            this.mnuDataMaintenance.Name = "mnuDataMaintenance";
            this.mnuDataMaintenance.Size = new System.Drawing.Size(147, 25);
            this.mnuDataMaintenance.Text = "Data Maintenance";
            // 
            // mnuEditData
            // 
            this.mnuEditData.Name = "mnuEditData";
            this.mnuEditData.Size = new System.Drawing.Size(142, 26);
            this.mnuEditData.Text = "Edit Data";
            // 
            // mnuWindows
            // 
            this.mnuWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTile,
            this.mnuCascade});
            this.mnuWindows.Name = "mnuWindows";
            this.mnuWindows.Size = new System.Drawing.Size(87, 25);
            this.mnuWindows.Text = "Windows";
            // 
            // mnuTile
            // 
            this.mnuTile.Name = "mnuTile";
            this.mnuTile.Size = new System.Drawing.Size(137, 26);
            this.mnuTile.Text = "Tile";
            // 
            // mnuCascade
            // 
            this.mnuCascade.Name = "mnuCascade";
            this.mnuCascade.Size = new System.Drawing.Size(137, 26);
            this.mnuCascade.Text = "Cascade";
            // 
            // tsMain
            // 
            this.tsMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsMain.Location = new System.Drawing.Point(0, 29);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1029, 25);
            this.tsMain.TabIndex = 3;
            this.tsMain.Text = "toolStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Hearty Hearth";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuDashboard;
        private ToolStripMenuItem mnuRecipes;
        private ToolStripMenuItem mnuRecipesList;
        private ToolStripMenuItem mnuNewRecipe;
        private ToolStripMenuItem mnuCloneARecipe;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuMealsList;
        private ToolStripMenuItem mnuCookbooks;
        private ToolStripMenuItem mnuCookbookList;
        private ToolStripMenuItem mnuNewCookbook;
        private ToolStripMenuItem mnuAutoCreateCookbook;
        private ToolStripMenuItem mnuDataMaintenance;
        private ToolStripMenuItem mnuEditData;
        private ToolStripMenuItem mnuWindows;
        private ToolStripMenuItem mnuTile;
        private ToolStripMenuItem mnuCascade;
        private ToolStrip tsMain;
    }
}