using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POIS1
{
    class Calculate
    {

        public double CalculateTotal(double cost, double quantity)
        {


            double result = Math.Abs(quantity * cost);
            return result;
        }
        public double CalculateTotal(double total, double tax, double discount)
        {
            double add = Math.Abs((total) + ((tax / 100) * total));
            double result = Math.Abs(add - discount);

            return result;
        }

        public double Tax(double tax)
        {
            double cal = Math.Abs(tax / 100);

            return tax;
        }

        public static double currency(double cost, double quantity, double total, double tax, double discount, double subtotal)
        {
            double usdtotal = Math.Abs((cost / 152) * (quantity / 152));
            double usdtotal1 = Math.Abs((total / 152) + ((tax / 100) * (total / 152)));
            double sub = Math.Abs(usdtotal1 - (discount / 152));



            return sub;
        }


    }

}
