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
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Close();
            login.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            MasterUser muser = new MasterUser();
            this.Close();
            muser.Show();
        }
    }
}
