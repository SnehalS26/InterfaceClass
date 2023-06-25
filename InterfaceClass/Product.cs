using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass
{


    public class Discount
    {
        int Id, OrigPrice;
        double DisPrice, DisPer, NewPrice;
        string Name;
        public Discount(int id, string name, int origPrice, double disPer)
        {
            this.Id = id;
            this.Name = name;
            this.OrigPrice = origPrice;
            //DisPrice = disPrice;
            this.DisPer = disPer;
            // NewPrice = newPrice;
        }
        public void Calculate()
        {
            DisPrice = OrigPrice * DisPer;
            NewPrice = OrigPrice - DisPrice;
        }
        public string Display()
        {
            return $"Product Id={Id},Product Name={Name}\"Original Price={OrigPrice},DiscountedPrice={DisPrice}";
        }
    }
}

