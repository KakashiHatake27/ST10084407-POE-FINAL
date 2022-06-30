using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePartThreeFinal
{
    abstract class ExpensesClass
    {

        /* Creating a new list of expenses. */
        public List<expense> expenses = new List<expense>();

        /* Creating a new instance of the expense class. */
        public expense exp = new expense();

        protected ExpensesClass()
        {
        }

        public void addExpense(string expenseType, double value) { 
            exp = new expense(expenseType,value);
            expenses.Add(exp);
        }

        /// This function calculates the total expenses of the company by adding all the expenses in the
        /// array
        /// returns
        /// The total expenses.
        public double calcTotalExpenses()
        {
            double totalExpenses = 0;
            for (int i = 0; i < expenses.Count; i++)
            {
                /* Adding the value of the expenses to the totalExpenses variable. */
                totalExpenses = totalExpenses + expenses[i].value;
            }


            return totalExpenses;
        }



        /// This function displays all the expenses in the expenses list
        public string displayAllExpenses()
        {
            string expenseList = "";

            /* Sorting the expenses list by the value of the expense using the SortExpense class. */
            expenses.Sort(new SortExpenses());


            /* Looping through the expenses list and adding the name and value of each expense to the
            expenseList string. */
            foreach (expense exp in expenses)
            {
                /* Adding the name and value of each expense to the expenseList string. */
                expenseList += "Expense " + exp.name + "- R " + exp.value + "\n";
            }

           return expenseList;

        }

    


        }



    }
