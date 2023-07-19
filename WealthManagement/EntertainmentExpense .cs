using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WealthManagement
{
    public class EntertainmentExpense : Expense
    {
        public EntertainmentExpense(string description, double amount) : base(description, amount)
        {
        }

        public double CalculateTax()
        {
            // Example logic: Calculate tax as 13% of the expense amount for housing expenses
            return Amount * 0.13;
        }
    }
}
