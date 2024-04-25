using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

     

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}