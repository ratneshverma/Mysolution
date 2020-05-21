using System;
using SecondSolution.Interface;
using SecondSolution.Resolver;
using Unity;

namespace SecondSolution.PromotionManager
{
    class PromotionEngine
    {
        static void Main(string[] args)
        {
            DependencyResolver.RegisterDependency();
            var promotionManager =  DependencyResolver.Container.Resolve<IPromotionEngineManager>();
            if(promotionManager!=null)
            {
                promotionManager.GetInput();
                var totalPrice = promotionManager.GetTotaalPrice();
                Console.WriteLine(totalPrice);
                Console.ReadLine();
            }
        }       
    }
    
}
