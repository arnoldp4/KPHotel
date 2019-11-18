using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPHotel
{
    public partial class MasterUser : Form
    {
        DateTime now = DateTime.Now;
        String tipeTxt;
        public MasterUser()
        {
            InitializeComponent();
        }

        private void MasterUser_Load(object sender, EventArgs e)
        {
            cbSearch.Items.Add("Nama");
            cbSearch.Items.Add("Tipe");
            cbSearch.Items.Add("Tanggal Buat");
            cbSearch.Text = cbSearch.Items[0].ToString();
            dgvUser.Rows.Add(new object[] { "U001", "admin", "admin", "Admin", "Admin", "11/11/2011", "1" });
            dgvUser.Rows.Add(new object[] { "U002", "arnoldp4", "arn", "Arnold", "Receptionist", "01/11/2019", "1" });
            dgvUser.Rows.Add(new object[] { "U003", "alt4rn", "alt", "Albert", "Chef", "01/01/2000", "1" });
            dgvUser.Rows.Add(new object[] { "U004", "arn_san", "arr", "Aaron", "Bellboy", "20/02/2020", "1" });
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MasterForm master = new MasterForm();
            this.Close();
            master.Show();
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text == "Tanggal Buat")
            {
                tipeTxt = cbSearch.Text;
                dtpSearch.Visible = true; dtpSearch.Value = now.Date;
                txtSearch.Visible = false; txtSearch.Text = "";
            }
            else
            {
                tipeTxt = cbSearch.Text;
                dtpSearch.Visible = false; dtpSearch.Value = now.Date;
                txtSearch.Visible = true; txtSearch.Text = "";
            }
        }

        private void dgvUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 2 && e.Value != null)
            {
                dgvUser.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text; int cekTable;
            if (tipeTxt == "Nama") cekTable = 3;
            else if (tipeTxt == "Tipe") cekTable = 4;
            else { cekTable = 5; searchValue = dtpSearch.Value.ToString("dd/MM/yyyy"); }

            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvUser.Rows)
                {
                    if (row.Cells[cekTable].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    } else if (cekTable == 5 && row.Cells[cekTable].Value.Equals(dtpSearch))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUser.Rows[e.RowIndex].Selected = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm(btnInsert.Text);
            this.Hide();
            edit.Show();
        }
    }
}
