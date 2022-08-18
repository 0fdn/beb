using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace htooncase2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char lett = e.KeyChar;
            if ((lett < 'А' || lett > 'Я') && (lett < 'а' || lett > 'я') && lett != '\b' && lett != ' ' && lett != '.')
            {
                e.Handled = true;
            }
        }
        private bool isNumber = false;
        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            isNumber = e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9
                || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9
                || e.KeyCode == Keys.Back
                || e.KeyCode == Keys.Delete;
        }
        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = (TextBox)sender;
            switch (e.KeyChar)
            {
                case '+':
                    if (box.Text.Length == 0)
                        isNumber = true;
                    break;
                case '8':
                    if (box.Text.Length == 0)
                        isNumber = true;
                    break;
                case '1':
                    if (box.Text.Length == 0)
                        isNumber = false;
                    break;
                case '2':
                    if (box.Text.Length == 0)
                        isNumber = false;
                    break;
                case '3':
                    if (box.Text.Length == 0)
                        isNumber = false;
                    break;
                case '4':
                    if (box.Text.Length == 0)
                        isNumber = false;
                    break;
                case '5':
                    if (box.Text.Length == 0)
                        isNumber = false;
                    break;
                case '6':
                    if (box.Text.Length == 0)
                        isNumber = false;
                    break;
                case '7':
                    if (box.Text.Length == 0)
                        isNumber = false;
                    if (box.Text.Length == 1)
                        isNumber = true;
                    break;
                case '9':
                    if (box.Text.Length == 0)
                        isNumber = false;
                    break;
                case '0':
                    if (box.Text.Length == 0)
                        isNumber = false;
                    break;
            }
            if (!isNumber)
                e.Handled = true;

        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            String fName, num, adr;
            fName = txtName.Text;
            num = txtNum.Text;
            adr = txtAdr.Text;
            lBox.Items.Add(lBox.Items.Count.ToString() + ": " + fName + ";" + num + ";" + adr);
        }
        private void bDelName_Click(object sender, EventArgs e)
        {
            txtName.Clear();
        }
        private void bDelNum_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
        }
        private void bReset_Click(object sender, EventArgs e)
        {
            lBox.Items.Clear();
        }

        private void bDelAdr_Click(object sender, EventArgs e)
        {
            txtAdr.Clear();
        }

        private void txtAdr_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtAdr_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void bDelVib_Click(object sender, EventArgs e)
        {
            lBox.Items.RemoveAt(lBox.SelectedIndex);
        }

        private void bDelTxt_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtNum.Clear();
            txtAdr.Clear();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}