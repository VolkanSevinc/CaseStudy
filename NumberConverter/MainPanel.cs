using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberConverter
{
    public partial class MainPanel : Form
    {
        private bool _isBritish;
        private readonly ConversionOperations _operations;

        public MainPanel()
        {
            _operations  = new ConversionOperations();
            _isBritish = true;
            InitializeComponent();           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _isBritish = radBritish.Checked == true;

            long element1 = _operations.StringtoInt(txtBxInput1.Text.ToLower());
            long element2 = _operations.StringtoInt(txtBxInput2.Text.ToLower());

            txtBxResult.Text = _operations.InttoString(element1 + element2, _isBritish);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _isBritish = radBritish.Checked == true;

            long element1 = _operations.StringtoInt(txtBxInput1.Text.ToLower());
            long element2 = _operations.StringtoInt(txtBxInput2.Text.ToLower());

            txtBxResult.Text = element2 == element1 ? "0" : _operations.InttoString(element1 - element2, _isBritish);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _isBritish = radBritish.Checked == true;
           
            long element1 = _operations.StringtoInt(txtBxInput1.Text.ToLower());
            long element2 = _operations.StringtoInt(txtBxInput2.Text.ToLower());

            if (element1 == 0 || element2 == 0)
            {

                txtBxResult.Text = "zero";
            }
            else
            {

                txtBxResult.Text = _operations.InttoString(element1 * element2, _isBritish);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _isBritish = radBritish.Checked == true;

            long element1 = _operations.StringtoInt(txtBxInput1.Text.ToLower());
            long element2 = _operations.StringtoInt(txtBxInput2.Text.ToLower());
           
            if (element1 == 0)
            {

                txtBxResult.Text = "zero";
            }
            else if (element2 == 0)
            {

                txtBxResult.Text = "Division by 0 is prohibited";
            }
            else
            {

                txtBxResult.Text = _operations.InttoString(element1 / element2, _isBritish);
            }
        }
        private void Text_Enter1(object sender, EventArgs e)
        {
            if (txtBxInput1.Text == "Please enter first number in written form")
            {
                txtBxInput1.Text = "";
                txtBxInput1.ForeColor = Color.Black;
            }
        }

        private void Text_Exit1(object sender, EventArgs e)
        {
            if (txtBxInput1.Text == "")
            {
                txtBxInput1.Text = "Please enter first number in written form";
                txtBxInput1.ForeColor = Color.Gray;
            }
        }

        private void Text_Enter2(object sender, EventArgs e)
        {
            if (txtBxInput2.Text == "Please enter second number in written form")
            {
                txtBxInput2.Text = "";
                txtBxInput2.ForeColor = Color.Black;
            }
        }

        private void Text_Exit2(object sender, EventArgs e)
        {
            if (txtBxInput2.Text == "")
            {
                txtBxInput2.Text = "Please enter second number in written form";
                txtBxInput2.ForeColor = Color.Gray;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
}

        private void radioButton1_CheckedChanged(object sender, EventArgs e){ }

        private void MainPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
