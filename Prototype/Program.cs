using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                FirstName = "Engin",
                LastName = "Demir",
                City = "Anakara",
                Id = 1
            };
            Console.WriteLine(customer.FirstName);

        }
    }

    public abstract class Person //Prototype 
    {
        public abstract Person Clone();

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Customer : Person
    {
        public string City { get; set; }

        public override Person Clone()
        {
            return (Person) MemberwiseClone();//MemberwiseClone(); Clonelamayı saglıyor
        }
    }

    public class Employee : Person
    {
        public decimal Salary { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();//MemberwiseClone(); Clonelamayı saglıyor
        }
    }
}
