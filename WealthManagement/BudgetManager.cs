using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WealthManagement
{

   
    public class BudgetManager
    {
        /* 
         Encapsulated the data fields budget and expenses.
         These fields are private, meaning they can only be accessed from within the BudgetManager class.
         */

        private double budget;
        private List<Expense> expenses;

        public BudgetManager(double budget)
        {
            this.budget = budget;
            expenses = new List<Expense>();
        }

        /*
         * Encapsulated the methods AddExpense and GetRemainingBudget. 
         These methods provide controlled access to the internal state of the BudgetManager object, allowing clients to add expenses and retrieve the remaining budget
         */
        public void AddExpense(Expense expense)
        {
            expenses.Add(expense);
            budget -= expense.Amount;
        }

        public double GetRemainingBudget()
        {
            return budget;
        }
    }
}
