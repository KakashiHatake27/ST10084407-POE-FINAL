using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePartThreeFinal
{
    internal class VehicleClass
    {
        /* Declaring the variables that will be used in the class. */
        private string makeModel;
        private double purchasePrice;
        private double deposit;
        private double interestRate;
        private double insurancePremium;

        /* A constructor. */
        public VehicleClass()
        {
        }


        public string MakeAndModel { get => makeModel; set => makeModel = value; }
        public double PurchasePrice { get => purchasePrice; set => purchasePrice = value; }
        public double Deposit { get => deposit; set => deposit = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        public double InsurancePremium { get => insurancePremium; set => insurancePremium = value; }



        public string showVehicle() {
            string vehicleInfo = "Vehicle Make and model" + MakeAndModel +
                "\nVehicle Purchase price" + PurchasePrice.ToString()+
                "\nVehicle Deposit" + Deposit.ToString()+
                "\nVehicle Interest" + InterestRate.ToString()+
                "\nVehicle Insurance" + InsurancePremium.ToString();

            return vehicleInfo;
        }

        /// The function calculates the monthly cost of a car loan by taking the purchase price,
        /// subtracting the deposit, multiplying the result by the interest rate, adding the insurance
        /// premium, and dividing the result by 60
        public double calcMonthlyCost()
        {
            double cost = 0;
            double monthlyCost = 0;

            double principleAmount = purchasePrice - deposit;
            interestRate = interestRate / 100;

            cost = principleAmount * (1 + (interestRate * 5));
            monthlyCost = cost / 60;

            monthlyCost += insurancePremium;

            return monthlyCost;
        }

    }
}
