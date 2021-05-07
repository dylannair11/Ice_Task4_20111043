using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DonutOrder
{
    class CollectCash
    {
        //https://www.youtube.com/watch?v=MFjlDbn7P8k&list=PL480DYS-b_keHacwHfXhHmHpWSI1n3Ff9&index=8
        public void collectCash(Order o)
        {
            MessageBox.Show("Collecting payment from - " + o.Name);
        }
    }
}
