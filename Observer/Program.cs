using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    //Product Price changed customers information
    class Program
    {
        static void Main(string[] args)
        {
            var observer = new CustomerObserver();
            ProductManager productManager = new ProductManager();
            productManager.Attach(observer);
            productManager.Attach(new EmployeeObserver());
            productManager.Detach(observer);
            productManager.UpdatePrice();

            Console.ReadLine();
        }
    }

    class ProductManager
    {
        List<Observer> _observers = new List<Observer>();
        public void UpdatePrice()
        {
            Console.WriteLine("Product price changed");
            Notify();
        }
        //Attach = eklemek , detach = ayırmak
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }
        //Notify = bildirmek
        private void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }

        }
    }

    //Observer = gözlemci

    abstract class Observer
    {
        public abstract void Update();
    }

    class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to cutomer : product price changed!");
        }
    }

    class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to employee : Product price changed!");
        }
    }
}
