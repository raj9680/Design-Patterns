using FactoryCustomer;
using MiddleLayer;
using System;
using System.Windows.Forms;

namespace WinFormCustomer
{
    public partial class FrmCustomer : Form
    {
        private CustomerBase cust = null;
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cust = Class1.Create(comboBox1.Text);
        }

        private void SetCustomer()
        {
            cust.CustomerName = textBox2.Text;
            cust.PhoneNumber = textBox4.Text;
            cust.BillDate = Convert.ToDateTime(textBox3.Text);
            cust.BillAmount = Convert.ToDecimal(textBox1.Text);
            cust.Address = richTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SetCustomer();
                cust.Validate();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
