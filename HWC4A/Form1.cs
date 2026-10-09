using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWC4A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateButton_Click(object sender, EventArgs e)
        {
            try
            {

                int userInput = int.Parse(yearInput.Text);
                DateTime dateTime = new DateTime(userInput, 1, 1);
                monthCalendar1.SetDate(dateTime);

            }
            catch (Exception)
            {
                MessageBox.Show("Enter a Valid Year", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void yearInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {

                e.Handled = true;
            }
        }
    }
}
