using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IProductService>().To<ProductManager>().InSingletonScope();
            kernel.Bind<IProductDal>().To<EfProductDal>().InSingletonScope();
            
            var product = kernel.Get<IProductService>();
            product.Save();
            Console.ReadLine();

        }
    }

    interface IProductDal
    {
        void Save();
    }
    class EfProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Product with Entity Freamwork");
        }
    }
    class NhProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Product with Nhibernate");
        }
    }

    interface IProductService
    {
        void Save();
    }

    class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Save()
        {
            _productDal.Save();
        }
    }
}
