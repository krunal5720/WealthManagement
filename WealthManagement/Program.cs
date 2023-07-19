using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WealthManagement
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Wealth Management - Budgeting and Expense Tracking!");
            Console.WriteLine();

            double budget = GetBudgetFromUser();
            BudgetManager budgetManager = new BudgetManager(budget);

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add expense");
                Console.WriteLine("2. View remaining budget");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Expense expense = GetExpenseFromUser();
                        budgetManager.AddExpense(expense);
                        break;
                    case "2":
                        Console.WriteLine($"Remaining budget: {budgetManager.GetRemainingBudget():C}");
                        break;
                    case "3":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
         }
        

        static double GetBudgetFromUser()
        {
            double budget;
            while (true)
            {
                Console.Write("Enter your budget: ");
                if (double.TryParse(Console.ReadLine(), out budget) && budget >= 0)
                    return budget;
                else
                    Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }
        }

        static Expense GetExpenseFromUser()
        {
            Console.Write("Enter the expense description: ");
            string description = Console.ReadLine();

            double amount;
            while (true)
            {
                Console.Write("Enter the expense amount: ");
                if (double.TryParse(Console.ReadLine(), out amount) && amount >= 0)
                    return new Expense(description, amount);
                else
                    Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }
        }
    }
}
