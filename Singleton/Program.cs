using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager(); ----------//Uretemeyiz Hata verir cunku constructor ı private yaptik singleton(tek şey) saglamak için
            var customerManager = CustomerManager.CreateAsSingleton();
            customerManager.Save();
            Console.ReadLine();

        }
    }

    class CustomerManager
    {
        private static CustomerManager _customerManager;
        private static  object _lockObject = new object();
        private CustomerManager()
        {
            
        }

        public static CustomerManager CreateAsSingleton()
        {
            lock (_lockObject) // aynı anda iki tane nesne olusturulmak istenirse olusturulma durumunu karsılık lock deyimini kullandık
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
            }

            return _customerManager;
        }

        public void Save()
        {
            Console.WriteLine("Saved!!");
        }
    }
}
