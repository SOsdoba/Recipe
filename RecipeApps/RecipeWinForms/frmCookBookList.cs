using CPUWindowsFormFramework;
using RecipeAppSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmCookBookList : Form
    {
        public frmCookBookList()
        {
            InitializeComponent();
            this.Activated += FrmCookBookList_Activated;
            ShowCookBookList();
            btnNewCookBook.Click += BtnNewCookBook_Click;
            gCookBooks.CellDoubleClick += GCookBooks_CellDoubleClick;
            gCookBooks.KeyDown += GCookBooks_KeyDown;
        }

        private void FrmCookBookList_Activated(object? sender, EventArgs e)
        {
            ShowCookBookList();
        }

        private void ShowCookBookList()
        {
            DataTable dt = CookBooks.SearchCookBooks();
            gCookBooks.DataSource = dt;
            gCookBooks.Columns["CookBookId"].Visible = false;
        }

        private void ShowCookBookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gCookBooks, rowindex, "CookBookId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookBook), id);
            }
        }

        private void BtnNewCookBook_Click(object? sender, EventArgs e)
        {
            ShowCookBookForm(-1);
        }

        private void GCookBooks_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gCookBooks.SelectedRows.Count > 0)
            {
                ShowCookBookForm(gCookBooks.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void GCookBooks_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookBookForm(e.RowIndex);
        }

    }
}
 