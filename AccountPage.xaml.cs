using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PoePartThreeFinal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AccountPage : Page
    {
        public AccountPage()
        {
            this.InitializeComponent();

            Expenses exp = new Expenses();
            Account acc = new Account();
            VehicleClass vehicle = new VehicleClass();

            Storage store = new Storage();

            string expenseList = acc.displayAllExpenses() + "\n" + vehicle.showVehicle();

            string tmp;

            tbIncome.Text ="Income - R" + store.ReadData("Income");
            tbExpense.Text = store.ReadData("Expense");
            tmp = tbExpense.Text;
            tbExpense.Text = tmp + "\n" + store.ReadData("Vehicle");

            tmp = tbExpense.Text;
            tbExpense.Text = tmp + "\n" + store.ReadData("Rental");

            tmp = tbExpense.Text;
            tbExpense.Text = tmp + "\n" + store.ReadData("House");

            tmp = tbExpense.Text;
            tbExpense.Text = tmp + "\n\n" +"Total Expenses - R" +store.ReadData("Total");



            var messageDialog2 = new MessageDialog(store.ReadVal("Income") + ",  "+ store.ReadVal("Total"));

             messageDialog2.ShowAsync();

            //double balance = Convert.ToDouble(store.ReadData("Income")) - Convert.ToDouble(store.ReadData("Total"));
            //tbBalance.Text = balance.ToString();
          

            if (!acc.checkApprovalLikeliness(Convert.ToDouble(store.ReadVal("Income"))))
            {
                tbWarning.Text = "ALERT: The approval of this home loan is unlikely";
            }


            if (!acc.checkExpenseRatio()) {
                tbExceed.Text = "ALERT! YOUR TOTAL EXPENSES ARE EXCEEDING 75% OF YOUR INCOME!!";
            }

        }
    }
}
