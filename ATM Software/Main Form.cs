using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CardNumbertextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int64 cardnumber = Convert.ToInt64(CardNumbertextBox.Text);
                int cardlength = cardnumber.ToString().Length;
                if (cardnumber.ToString().Length == 10)
                {
                    panelPIN.Visible = true;
                    InsertCardPanel.Visible = false;
                    PINtextBox.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CardNumbertextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
