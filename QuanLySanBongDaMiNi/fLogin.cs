using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBongDaMiNi
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();      
        }
        private void bttLogin_Click(object sender, EventArgs e)
        {
            SanBongManager formQLSB = new SanBongManager();
            this.Hide();
            formQLSB.ShowDialog();
            this.Show();
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình ?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
