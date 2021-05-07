using System;
using System.Collections.Generic;
using System.Text;

namespace DonutOrder
{
    ////https://www.youtube.com/watch?v=MFjlDbn7P8k&list=PL480DYS-b_keHacwHfXhHmHpWSI1n3Ff9&index=8
    

    class ProcessOrder
    {
        public delegate void ProcessOrderDelegate(Order o);

        public event ProcessOrderDelegate OrderSubmitted;
        
        
        public void Process(Order o)
        {
            CollectCash cs = new CollectCash();
            Donuteer d = new Donuteer();
            Barista b = new Barista();

            OrderSubmitted += cs.collectCash;
            OrderSubmitted += d.packDonuts;
            OrderSubmitted += b.makeCoffees;
            
            //cs.collectCash(o);
            //d.packDonuts(o);
            //b.makeCoffees(o);

            OnOrderSubmitted(o);

        }

        protected virtual void OnOrderSubmitted(Order o)
        {
            if (OrderSubmitted != null)
            {
                OrderSubmitted(o)
            }
        }
    }
}
