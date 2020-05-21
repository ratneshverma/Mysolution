using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondSolution.Interface;
using SecondSolution.Utility;
using SecondSolution.PromotionManager;
using Unity;

namespace SecondSolution.Resolver
{
    internal class DependencyResolver
    {
        internal static UnityContainer Container { get; } = new UnityContainer();
        internal static void RegisterDependency()
        {
            Container.RegisterType<IProductUtility, ProductUtility>();
            Container.RegisterType<IPromotionEngineManager, PromotionEngineManager>();
        }

    }
}
