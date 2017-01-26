using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP
{
    public class Varer
    {
       // private string _describtion;
       // private double _price;
        public string Describtion { get; set; }
        public double Price { get; set; }
        public Varer(string describtion, double price)
        {
            Describtion = describtion;
            Price = price;
        }
        public double GetCurrentValue()
        {
            return Price;
        }

        public override string ToString()
        {
            return string.Format(Describtion+ "," + Price);
            //"_describtion:{0} _price: {1}",
            //    _describtion, _price);

            }
        }
    }

