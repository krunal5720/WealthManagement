using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WealthManagement
{
    /// <summary>
    /// Represents an expense with properties for description and amount.
    /// </summary>
    public class Expense
    {
        public string Description { get;set; }
        public double Amount { get;set; }

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="description">description</param>
        /// <param name="amount">amount</param>
        public Expense(string description, double amount)
        {
            Description = description;
            Amount = amount;
        }
    }
}
