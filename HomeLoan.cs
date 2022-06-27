using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePartThreeFinal
{
    internal class HomeLoan
    {
        /* Declaring the variables that will be used in the program. */
        private double purchasePrice;
        private double totalDeposit;
        private double interest;
        private int monthsRepay;
        private double principleAmount;
        private double totalOutstanding;
        private double homeLoanRepayments;


        ///
        /// This function gets the user's input for the home loan and then calls the function to
        /// calculate the monthly loan repayment
        /// 
        public void getHomeLoan()
        {
            /* This is the user interface. It is asking the user to enter the details for the home
            loan. */
            Console.WriteLine("\n-------------------------------------------\n");
            Console.WriteLine("Please enter the following details for a home loan: ");

            Console.Write("\nPurchase price of property: R ");
            purchasePrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Total Deposit: R ");
            totalDeposit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Interest rate (in percentage %): ");
            interest = Convert.ToDouble(Console.ReadLine());

            Console.Write("Number of months to complete payment(240 - 360): ");
            monthsRepay = Int32.Parse(Console.ReadLine());

            /* Calling the function to calculate the monthly loan repayment. */
            calcMonthlyLoanRepayment();
        }

        /// 
        /// Calculate the monthly loan repayment by taking the principle amount, interest rate and the
        /// number of months to repay the loan
        /// 
        /// The monthly loan repayment is being returned.
        /// 
        public double calcMonthlyLoanRepayment()
        {

            /* This is calculating the principle amount, interest rate and the number of years to repay
            the loan. */
            principleAmount = purchasePrice - totalDeposit;
            interest = interest / 100;
            int years = monthsRepay / 12;

            /* Calculating the total outstanding amount of the loan. */
            totalOutstanding = principleAmount * (1 + (interest * years));

            /* This is calculating the monthly loan repayment by taking the total outstanding amount of
            the loan and dividing it by the number of months to repay the loan. The monthly loan
            repayment is then rounded to 2 decimal places. */
            homeLoanRepayments = totalOutstanding / monthsRepay;
            homeLoanRepayments = Math.Round(homeLoanRepayments, 2);

            return homeLoanRepayments;
        }


    }
}
