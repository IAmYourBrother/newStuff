using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectLibs;

namespace CandyMachine
{
    public partial class Input : Form
    {
        Form1 myForm1;
        private int coins;
        string str;
        public Input()
        {
            InitializeComponent();
        }
        public int Coins
        {
            get 
            {
                return coins; 
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            coins = Convert.ToInt32(txtInput.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Input_Load(object sender, EventArgs e)
        {
            myForm1 = new Form1();
            str = String.Format("To buy please insert coins.");
            lbl1.Text = str + myForm1.ProdName;
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
