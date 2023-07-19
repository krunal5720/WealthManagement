using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WealthManagement
{
    /*
     * Encapsulated the data fields Description and Amount using auto-implemented properties. 
     * These properties provide access to the class's internal data, allowing controlled access to the Expense object's attributes from outside the class.
     */
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
