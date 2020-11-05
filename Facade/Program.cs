using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Save();
            Console.ReadLine();
        }
    }

    class Logging:ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged!");
        }
    }

    internal interface ILogging
    {
        void Log();
    }

    class Caching:ICahcing
    {
        public void Cache()
        {
            Console.WriteLine("Cached!");
        }
    }

    interface ICahcing
    {
        void Cache();
    }


    class Authorize:IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("User Checked");
        }
    }

    internal interface IAuthorize
    {
        void CheckUser();
    }

    class Validation : IValidate
    {
        public void Validate()
        {
            Console.WriteLine("Validated");
        }
    }

    internal interface IValidate
    {
        void Validate();
    }

    class CustomerManager
    {
        private CrossCuttongConcernsFacede _concerns;

        public CustomerManager()
        {
            _concerns = new CrossCuttongConcernsFacede();
        }

        public void Save()
        {
            _concerns.Logging.Log();
            _concerns.Cahcing.Cache();
            _concerns.Authorize.CheckUser();
            _concerns.Validation.Validate();
            Console.WriteLine("Saved!");
        }

    }

    class CrossCuttongConcernsFacede
    {
        public ILogging Logging;
        public ICahcing Cahcing;
        public IAuthorize Authorize;
        public IValidate Validation;

        public CrossCuttongConcernsFacede()
        {
            Logging = new Logging();
            Cahcing = new Caching();
            Authorize = new Authorize();
            Validation = new Validation();

        }
        
    }
}
