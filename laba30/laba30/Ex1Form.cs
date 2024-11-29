using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba30
{
    public partial class Ex1Form : Form
    {
        public Ex1Form()
        {
            InitializeComponent();
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WassupBroButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ЗДАРОВА БРАТИШКА");
        }

        private void WassupBroButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("ЗДАРОВА БРАТИШКА");
            }
        }

        private void CloseFormButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar is (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
