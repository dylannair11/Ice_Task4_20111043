using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonutOrder
{
    public partial class FrmOrder : Form
    {
        //https://www.youtube.com/watch?v=MFjlDbn7P8k&list=PL480DYS-b_keHacwHfXhHmHpWSI1n3Ff9&index=8
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            int donuts = Convert.ToInt32(txbDonuts.Text);
            int coffees = Convert.ToInt32(txbCoffees.Text);

            Order o = new Order(name, coffees, donuts);

            ProcessOrder p = new ProcessOrder();
            p.Process(o);

        }

       
    }
}
