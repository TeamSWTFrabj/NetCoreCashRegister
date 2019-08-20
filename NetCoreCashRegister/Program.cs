using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkCashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Register reg = new Register();

            reg.AddItem(12.34);

            System.Console.WriteLine("Der er {0} varer til en værdi af {1}", reg.GetNItems(), reg.GetTotal());

            if (reg.GetNItems() != 0)
            {
                System.Console.WriteLine("Register returnerede forkert antal varer");
            }

            if (reg.GetTotal() != 12.34)
            {
                System.Console.WriteLine("Register returnerede forkert total sum");
            }

            try
            {
                reg.AddItem(-23.45);
                // Hvis vi er kommet hertil, blev der ikke smidt en exception!
                System.Console.WriteLine("Register udløste IKKE en exception på et negativt item");
            }
            catch (Exception e)
            {
                Console.WriteLine("Register udløste en exception med følgende besked: {0}", e.Message);
            }

        }
    }
}
