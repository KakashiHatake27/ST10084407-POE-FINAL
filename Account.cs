using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePartThreeFinal
{
    /* A delegate that is being used to get the monthly rental amount from the user. */
    public delegate double getRentalDelegate();

    /* Inheriting the Expenses class. */
    internal class Account : ExpensesClass
    {

        public const string EXCEED_MESSAGE = "ALERT! YOUR TOTAL EXPENSES ARE EXCEEDING 75% OF YOUR INCOME!!!";
        public const string UNLIKELY_APPROVAL_MESSAGE = "\nALERT: The approval of this home loan is unlikely";

        /* Declaring the variables. */
        private double grossMonthlyIncome;
        private double accountBalance;
        private double Rental;
        

        public double AccountBalance { get => accountBalance; set => accountBalance = value; }
        public double GrossMonthlyIncome { get => grossMonthlyIncome; set => grossMonthlyIncome = value; }
        //public double Rental { get => rental; set => rental = value; }

        private int housing;

        /* Creating a new instance of the HomeLoan class. */
        HomeLoan hl = new HomeLoan();


        /* Creating a delegate. */
        public delegate void homeLoanDelegate();
        public delegate double getRentalDelegate();


        /// It displays the account balance in the console
        public double showBalance()
        {
            return accountBalance;
        }

        public bool isBalBelowZero()
        {
            if (accountBalance < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void setRental(double rental) {
            Rental = rental;
            addExpense("Rental", rental);
        }

        public double getRental() {
            return Rental;
        }

        /// The function getIncome() gets the gross monthly income from the user and increases the
        /// balance by the gross monthly income.
        /// returns
        /// The grossMonthlyIncome is being returned.
        public double getIncome()
        {
            return grossMonthlyIncome;
        }


        public void setIncome(double income)
        {
            grossMonthlyIncome = income;

            /* Increasing the balance by the gross monthly income. */
            increaseBalance(grossMonthlyIncome);
        }



        /// The function is supposed to ask the user to select between renting or buying a property. If
        /// the user selects renting, the function should call the delegate grd which will ask the user
        /// to enter the monthly rental amount. If the user selects buying a property, the function
        /// should call the getHomeLoan() function which is in the HomeLoan class
        public void GetHousing()
        {
            /* A delegate that is being used to get the monthly rental amount from the user. */
            getRentalDelegate grd = () =>
            {
                double rental;
                Console.Write("\nPlease enter monthly rental amount: R ");
                rental = Int32.Parse(Console.ReadLine());
                return rental;
            };

            Console.WriteLine("\n ACCOMMODATION:\n-------------------");

            /* Asking the user to select between renting or buying a property. */
            Console.WriteLine("\nPlease enter number to select your accommodation\n\t[1] Renting\n\t[2] Buying a property");
            Console.Write(" --> ");
            housing = Int32.Parse(Console.ReadLine());

            /* Asking the user to select between renting or buying a property. Depending on the selection the 
            appropriate action is executed*/
            if (housing == 1)
            {
                grd.Invoke();
            }
            else if (housing == 2)
            {
                hl.getHomeLoan();
            }
            else
            {
                /* If it is an invalid input it shows the following error and runs the method again. */

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Invalid input, Please try again.\n");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                GetHousing();
            }

        }



        /// This function reduces the balance of the account by the amount passed in as a parameter
        ///The amount to reduce the balance by.
        public void reduceBalance(double reduction)
        {
            accountBalance -= reduction;
        }


        /// It increases the balance of the account by the amount passed in.
        /// The amount to increase the balance by
        public void increaseBalance(double increase)
        {
            accountBalance += increase;
        }


        /// This function checks if the monthly loan repayment is less than a third of the gross monthly
        /// income. If it is, it prints an alert to the console
        /// gmi = Gross Monthly Income
        public bool checkApprovalLikeliness(double gmi)
        {

            if ((gmi / 3) < hl.calcMonthlyLoanRepayment())
            {

                //Console.WriteLine("\nALERT: The approval of this home loan is unlikely");
                return true;
            }
            else { 
            return false;
            }
        }

        /// This function reduces the balance by the monthly cost of a vehicle.
        public void reduceVehicleExpense()
        {
            VehicleClass vehicle = new VehicleClass();

            reduceBalance(vehicle.calcMonthlyCost());
        }




        /// This function checks to see if the total expenses are greater than 75% of the gross monthly
        /// income. If it is, it will display an alert message
        public bool checkExpenseRatio()
        {
            /* Calculating the 75% of the gross monthly income. */
            double partIncome = grossMonthlyIncome * (75 / 100);

            if (calcTotalExpenses() > partIncome)
            {
                //Console.WriteLine("\nALERT! YOUR TOTAL EXPENSES ARE EXCEEDING 75% OF YOUR INCOME!!!");

                return true;
            }
            else
            {
                /* Returning nothing. */
                return false;
            }

        }


    }
}
