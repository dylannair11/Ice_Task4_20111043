using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DonutOrder
{
    class Donuteer
    {
        //https://www.youtube.com/watch?v=MFjlDbn7P8k&list=PL480DYS-b_keHacwHfXhHmHpWSI1n3Ff9&index=8
        public void packDonuts(Order o)
        {
            MessageBox.Show("Packing donuts - " + o.Coffees);
        }
    }
}
