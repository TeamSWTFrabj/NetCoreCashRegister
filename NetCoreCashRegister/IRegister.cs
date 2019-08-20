using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkCashRegister
{
    public interface IRegister
    {
        void AddItem(double price);
        int GetNItems();
        double GetTotal();
    }
}
