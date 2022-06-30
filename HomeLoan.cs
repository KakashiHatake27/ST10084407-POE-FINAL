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

        public double PurchasePrice { get => purchasePrice; set => purchasePrice = value; }
        public double TotalDeposit { get => totalDeposit; set => totalDeposit = value; }
        public double Interest { get => interest; set => interest = value; }
        public int MonthsRepay { get => monthsRepay; set => monthsRepay = value; }
        public double PrincipleAmount { get => principleAmount; set => principleAmount = value; }
        public double TotalOutstanding { get => totalOutstanding; set => totalOutstanding = value; }
        public double HomeLoanRepayments { get => homeLoanRepayments; set => homeLoanRepayments = value; }


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
            PurchasePrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Total Deposit: R ");
            TotalDeposit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Interest rate (in percentage %): ");
            Interest = Convert.ToDouble(Console.ReadLine());

            Console.Write("Number of months to complete payment(240 - 360): ");
            MonthsRepay = Int32.Parse(Console.ReadLine());

            /* Calling the function to calculate the monthly loan repayment. */
            calcMonthlyLoanRepayment();
        }


        public string displayInfo() {

            string info = "House Purchase price - R" + PurchasePrice.ToString() +
                "\nHouse Total Deposit - R" + TotalDeposit.ToString() +
                "\nHouse Interest " + Interest.ToString() + "%" +
                "\nHouse Months to repay " + MonthsRepay.ToString();

            return info;
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
            PrincipleAmount = PurchasePrice - TotalDeposit;
            Interest = Interest / 100;
            int years = MonthsRepay / 12;

            /* Calculating the total outstanding amount of the loan. */
            TotalOutstanding = PrincipleAmount * (1 + (Interest * years));

            /* This is calculating the monthly loan repayment by taking the total outstanding amount of
            the loan and dividing it by the number of months to repay the loan. The monthly loan
            repayment is then rounded to 2 decimal places. */
            HomeLoanRepayments = TotalOutstanding / MonthsRepay;
            HomeLoanRepayments = Math.Round(HomeLoanRepayments, 2);

            return HomeLoanRepayments;
        }


    }
}
