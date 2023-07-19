using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WealthManagement
{
    public  class BudgetManager
    {
        private double budget;
        private List<Expense> expenses;

        public BudgetManager(double budget)
        {
            this.budget = budget;
            expenses = new List<Expense>();
        }

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
