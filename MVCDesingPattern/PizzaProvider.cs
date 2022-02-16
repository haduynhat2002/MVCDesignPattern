using System;
using System.Collections.Generic;
using System.Text;

namespace MVCDesingPattern
{
    class PizzaProvider: IPizza
    {
        public void GetNonVegPizza()
        {
            GetNonVegToppings();
            Console.WriteLine("Getting Non Veg Pizza.");
        }
        public void GetVegPizza()
        {
            Console.WriteLine("Getting Veg Pizza.");
        }
        private void GetNonVegToppings()
        {
            Console.WriteLine("Getting Non Veg Pizza Toppings.");
        }
    }

    internal interface IPizza
    {
        void GetVegPizza();
        void GetNonVegPizza();
    }
}
