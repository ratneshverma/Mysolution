using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondSolution.Interface;
using SecondSolution.Model;

namespace SecondSolution.PromotionManager
{
    internal class PromotionEngineManager : IPromotionEngineManager
    {
        IProductUtility _productUtility;
        List<IProduct> products = new List<IProduct>();
        internal PromotionEngineManager(IProductUtility productUtility)
        {
            _productUtility = productUtility;
        }

        public void GetInput()
        {
            Console.WriteLine("total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                IProduct p = new Product(type);
                products.Add(p);
            }
        }

        public int GetTotaalPrice()
        {
           return _productUtility.GetTotalPrice(products);
        }

        
    }
}
