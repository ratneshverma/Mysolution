using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondSolution.Interface;
using SecondSolution.Model;

namespace SecondSolution.Utility
{
    internal class ProductUtility : IProductUtility
    {
        public int GetTotalPrice(List<IProduct> products)
        {
            int counterofA = 0;
            int priceofA = 0;
            int counterofB = 0;
            int priceofB = 0;
            int CounterofC = 0;
            int priceofC = 0;
            int CounterofD = 0;
            int priceofD = 0;
            foreach (IProduct pr in products)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    priceofA = Convert.ToInt32(pr.Price);
                    counterofA = counterofA + 1;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    priceofB = Convert.ToInt32(pr.Price);
                    counterofB = counterofB + 1;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    priceofC = Convert.ToInt32(pr.Price);
                    CounterofC = CounterofC + 1;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    priceofD = Convert.ToInt32(pr.Price);
                    CounterofD = CounterofD + 1;
                }
            }
            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            if (priceofC != 0 && priceofD != 0)
            {
                int totalPriceofCD = 30;
                return totalPriceofA + totalPriceofB + totalPriceofCD;
            }
            int totalPriceofC = (CounterofC * priceofC);
            int totalPriceofD = (CounterofD * priceofD);
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;

        }
    }
}
