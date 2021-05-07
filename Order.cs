using System;
using System.Collections.Generic;
using System.Text;

namespace DonutOrder
{
    class Order
    {
        //https://www.youtube.com/watch?v=MFjlDbn7P8k&list=PL480DYS-b_keHacwHfXhHmHpWSI1n3Ff9&index=8
        public Order(string name, int coffees, int donuts)
        {
            Name = name;
            Coffees = coffees;
            Donuts = donuts;
        }

        public string Name { get; set; }
        public int Coffees { get; set; }
        public int Donuts { get; set; }

        public override string ToString()
        {
            return this.Name + " : " + this.Coffees + "Coffees & " + this.Donuts + "Donuts" ;
        }
    }
}
