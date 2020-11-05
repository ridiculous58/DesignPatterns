using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChainOfResponsibility //Sorumluluk Deseni
{
    class Program
    {
        //100 tl ve uzeri mudur ,1000 tl ve uzeri ceo ,10000 tl ve uzeri patron
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            VicePresident vicePresident=new VicePresident();
            President president = new President();

            manager.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);
            //Training = egitim
            Expense expense = new Expense{Amount = 10000 ,Detail = "Training"};
            manager.HandleExpense(expense);

            Console.ReadLine();
        }
    }

    class Expense//gider harcama
    {
        public string Detail { get; set; }
        public decimal Amount { get; set; }
        
    }

    abstract class ExpenseHandlerBase
    {
        protected ExpenseHandlerBase Successor;

        public abstract void HandleExpense(Expense expense);

        public void SetSuccessor(ExpenseHandlerBase successor)
        {
            Successor = successor;
        }
    }

    class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount <= 100)
            {
                Console.WriteLine("Manager handled the expense!");
            }
            else if (Successor != null)
            {
                Successor.HandleExpense(expense);
            }
                
        }
    }
    class VicePresident : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 100 && expense.Amount <= 1000)
            {
                Console.WriteLine("Vice President handled the expense!");
            }
            else if (Successor != null)
            {
                Successor.HandleExpense(expense);
            }
        }
    }
    class President : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 1000)
            {
                Console.WriteLine("President handled the expense!");
            }
        }
    }
}
