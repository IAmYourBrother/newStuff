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
    public partial class Form1 : Form
    {
        CashRegister myCashReg = new CashRegister(100);
        Dispenser dispCandy = new Dispenser(1, 2);
        Dispenser dispChips = new Dispenser(10, 10);
        Dispenser dispGum = new Dispenser(10, 5);
        Dispenser dispCookies = new Dispenser(10, 20);
        Input myInput = new Input();

        private string prodName;
        private int prodCost;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void sellProduct(Dispenser product, string productName)
        {
           
            int coinsInserted = 0;
            int price;
            int coinsRequired;
            //string str;
            if (product.GetCount > 0)
            {
                price = product.GetProductCost();
               
           
                MessageBox.Show(product.GetCount.ToString());               
                myInput.ShowDialog();
                coinsInserted = myInput.Coins;
                coinsRequired = price - coinsInserted;
                if (coinsRequired <= 0)
                {
                    myCashReg.AcceptAmount(coinsInserted);
                    product.MakeSale();
                    MessageBox.Show("Hi there!", "Please pick up your " + productName + " and enjoy!\n Thank You and Come again!");   
                }
                else
                {
                    MessageBox.Show("Insufficient Amount! You need " + coinsRequired + " more.");
                }                
            }
            else
            {
                MessageBox.Show("Error","Sorry, "+productName+" is sold out");
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            
            if (rbCandy.Checked)
            {
                SetProductName("Candy");
                sellProduct(dispCandy, "Candy");
            }
            else if (rbChips.Checked)
            {
                sellProduct(dispChips, "Chips");
            }
            else if (rbCookies.Checked)
            {
                sellProduct(dispCookies, "Cookies");
            }
            else if (rbGum.Checked)
            {
                sellProduct(dispGum, "Gum");
            }
            else 
            {
                MessageBox.Show("You have not selected any product!");
            }            
        }
        private string SetProductName(string productName) 
        {
            prodName = productName;
            return productName;
        }
        public string ProdName 
        {
            get
            {
                return prodName;
            }
            set
            {
             
                prodName = value;
            }
        }
    }
}
