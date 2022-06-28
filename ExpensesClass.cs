using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePartThreeFinal
{
    abstract class ExpensesClass
    {

        /* Creating a new instance of the Vehicle class. */
        VehicleClass vehicle = new VehicleClass();

        /* Creating a new list of expenses. */
        public List<expense> expenses = new List<expense>();

        /* Creating a new instance of the expense class. */
        public expense exp = new expense();

        protected ExpensesClass()
        {
        }

        /// It gets the user's input and stores it in an array
        public void GetInput()
        {
            /* Creating an array of 10 elements. */


            /* Printing the heading for expeneses. */
            Console.WriteLine("\n EXPENSES:\n-------------------");

            /* Asking the user to enter the estimated monthly tax and then it is converting it to a
            double and then it is adding it to the array. */
            Console.Write("Enter estimated monthly tax: ");
            //expense.Add("Tax", Convert.ToDouble(Console.ReadLine()));
            //expense.Add("Tax", 26.9);
            exp = new expense("Tax", Convert.ToDouble(Console.ReadLine()));
            expenses.Add(exp);

            /* Printing the text "Please enter monthly estimated cost of the following:" on the console. */
            Console.WriteLine("\nPlease enter monthly estimated cost of the following:");


            /* Asking the user to enter the estimated monthly cost of groceries and then it is
            converting it to a double and then it is adding it to the array. */
            Console.Write("Groceries: R ");
            exp = new expense("Groceries", Convert.ToDouble(Console.ReadLine()));
            expenses.Add(exp);

            /* Asking the user to enter the estimated monthly cost of water and lights and then it is
            converting it to a double and then it is adding it to the array. */
            Console.Write("Water and lights: R ");
            exp = new expense("Water and lights", Convert.ToDouble(Console.ReadLine()));
            expenses.Add(exp);

            /* Asking the user to enter the estimated monthly cost of travel costs and then it is
            converting it to a double and then it is adding it to the array. */
            Console.Write("Travel costs(including fuel): R ");
            exp = new expense("Travel costs", Convert.ToDouble(Console.ReadLine()));
            expenses.Add(exp);

            /* Asking the user to enter the estimated monthly cost of cell phone and telephone and then
            it is
            converting it to a double and then it is adding it to the array. */
            Console.Write("Cell phone and Telephone: R ");
            exp = new expense("Cell phone and Telephone", Convert.ToDouble(Console.ReadLine()));
            expenses.Add(exp);

            /* Asking the user to enter the estimated monthly cost of any other miscellaneous expenses
            and then it is converting it to a double and then it is adding it to the array. */
            Console.Write("Any other miscellanous expenses: R ");
            exp = new expense("other", Convert.ToDouble(Console.ReadLine()));
            expenses.Add(exp);

        }


        public void addExpense(string expenseType, double value) { 
            exp = new expense(expenseType,value);
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
            string expenseList = "\nAll Expenses\n-------------------\n";

            /* Sorting the expenses list by the value of the expense using the SortExpense class. */
            expenses.Sort(new SortExpenses());


            /* Looping through the expenses list and adding the name and value of each expense to the
            expenseList string. */
            foreach (expense exp in expenses)
            {
                /* Adding the name and value of each expense to the expenseList string. */
                expenseList += exp.name + "-> R " + exp.value + "\n";
            }

           return expenseList;

        }

        /* Asking the user if they would like to buy a car and if they do it will ask them for the make
        and model of the car, the purchase price of the car, the total deposit for the car, the
        interest rate percentage for the car and the estimated insurance premium of the car. */
        public void buyCar()
        {
            string choice;

            Console.Write("\nWould you like to purchase a vehicle:\n[y] - Yes\n[n] - No\n>>>");
            choice = Console.ReadLine();

            /* Asking the user if they would like to buy a car and if they do it will ask them for the
            make and model of the car, the purchase price of the car, the total deposit for the car,
            the interest rate percentage for the car and the estimated insurance premium of the car. */
            // If the user enters "y" or "Y", the function will return true. 
            if (choice == "y")
            {

                Console.WriteLine("\nBuy a car:\n-------------------");

                Console.Write("\nEnter make and model of the vehicle: ");
                vehicle.MakeAndModel = Console.ReadLine();

                Console.Write("\nEnter the purchase price of the vehicle: R ");
                vehicle.PurchasePrice = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEnter total deposit for the vehicle: R ");
                vehicle.Deposit = Convert.ToDouble(Console.ReadLine());


                Console.Write("\nEnter the interest rate percentage for the vehicle: ");
                vehicle.InterestRate = Int32.Parse(Console.ReadLine());

                Console.Write("\nEnter the estimated insurance premium of the vehicle: R ");
                vehicle.Deposit = Convert.ToDouble(Console.ReadLine());


                exp = new expense("Monthly Car payment", vehicle.calcMonthlyCost());
                expenses.Add(exp);
            }

            ///If the user enters "n" or
            /// "N", the function will return false. If the user enters anything else, the function will
            /// ask the user to enter a valid choice
            else if (choice == "n")
            {
                return;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("\nInvalid Input!\nPlease type y for yes and n for no");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                buyCar();
            }


        }



    }
}
