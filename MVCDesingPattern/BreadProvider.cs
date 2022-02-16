using System;
using System.Collections.Generic;
using System.Text;

namespace MVCDesingPattern
{
    internal interface IBread
    {
        void GetGarlicBread();
        void GetCheesyGarlicBread();
    }
    class BreadProvider : IBread
    {
        public void GetGarlicBread()
        {
            Console.WriteLine("Getting Garlic Bread.");
        }
        public void GetCheesyGarlicBread()
        {
            GetCheese();
            Console.WriteLine("Getting Cheesy Garlic Bread.");
        }
        private void GetCheese()
        {
            Console.WriteLine("Getting Cheese.");
        }
    }
}
