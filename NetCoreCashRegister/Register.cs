using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkCashRegister
{
    public class Register : IRegister
    {
        public int NoOfItems { get; set; }
        private double total_;

        public Register()
        {
            NoOfItems = 0;
            total_ = 0;
        }

        public void AddItem(double price)
        {
            if (price < 0)
                throw new ArgumentException("Negativ item værdi");
            total_ += price;
            NoOfItems++;
        }

        public int GetNItems()
        {
            return NoOfItems;
        }

        public double GetTotal()
        {
            return total_;
        }
    }
}
