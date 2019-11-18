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
    public partial class EditForm : Form
    {
        String cekEdit;
        public EditForm(String editphase)
        {
            cekEdit = editphase;
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            cbTipe.Items.Add("Receptionist");
            cbTipe.Items.Add("Bellboy");
            cbTipe.Items.Add("Chef");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
