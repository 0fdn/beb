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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private bool isNumber = false;
        private void KeyDownTxt(object sender, KeyEventArgs e)
        {
            isNumber = e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9
                || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9
                || e.KeyCode == Keys.Back
                || e.KeyCode == Keys.Delete;
        }
        private void KeyPressTxt(object sender, KeyPressEventArgs e)
        {
            TextBox box = (TextBox)sender;
            switch (e.KeyChar)
            {
                case '-':
                    if (box.Text.Length == 0)
                        isNumber = true;
                    break;
                case '.':
                    if (box.Text.Length == 0)
                        break;
                    if (box.Text[0] == '-' && box.Text.Length == 1)
                        break;
                    if (box.Text.IndexOf('.') == -1)
                        isNumber = true;
                    break;
            }
            if (!isNumber)
                e.Handled = true;
        }
        private double numFst, numSnd, numRes;

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void txtRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFst_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

            Form frm = new Form2();
            frm.Show();
            this.Close();

        }

        private void bClckd(object sender, EventArgs e)
        {
            string strFst = string.Copy(txtFst.Text);
            string strSnd = string.Copy(txtSnd.Text);

            int pos = strFst.IndexOf('.');
            if (pos != -1)
            {
                strFst = strFst.Substring(0, pos) + ',' + strFst.Substring(pos + 1);
            }
            pos = strSnd.IndexOf('.');
            if (pos != -1)
            {
                strSnd = strSnd.Substring(0, pos) + ',' + strSnd.Substring(pos + 1);
            }
            if (txtFst.Text.Length > 0)
                numFst = Convert.ToDouble(strFst);
            else
                numFst = 0.0D;
            if (txtSnd.Text.Length > 0)
                numSnd = Convert.ToDouble(strSnd);
            else
                numSnd = 0.0D;
            string bTxt = "";
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "bCor":
                    double number = double.Parse(txtFst.Text);
                    bTxt = "\"cor\"";
                    numRes = Math.Sqrt(number);
                    txtRes.Text = numRes.ToString();
                    break;
                case "bQuad":
                    bTxt = "\"^\"";
                    numRes = numFst * numFst;
                    txtRes.Text = numRes.ToString();
                    break;
                case "bPls":
                    bTxt = "\"+\"";
                    numRes = numFst + numSnd;
                    txtRes.Text = numRes.ToString();
                    break;
                case "bMin":
                    bTxt = "\"-\"";
                    numRes = numFst - numSnd;
                    txtRes.Text = numRes.ToString();
                    break;
                case "bDel":
                    bTxt = "\"/\"";
                    numRes = numFst / numSnd;
                    txtRes.Text = numRes.ToString();
                    break;
                case "bUmn":
                    bTxt = "\"*\"";
                    numRes = numFst * numSnd;
                    txtRes.Text = numRes.ToString();
                    break;
            }
            System.Diagnostics.Debug.WriteLine("ВЫ нажали кнопку! Теперь вы абобус." + bTxt);

        }

 
    }
}