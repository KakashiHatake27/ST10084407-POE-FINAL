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
    public sealed partial class Expenses : Page
    {
        public Expenses()
        {
            this.InitializeComponent();
        }

        Account account = new Account();
        //ExpensesClass exp = new ExpensesClass();

        private async void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            account.addExpense("Monthly Tax", Convert.ToDouble(tbMonthlyTax.Text));
            account.addExpense("Groceries", Convert.ToDouble(tbGroceries.Text));
            account.addExpense("Water and lights", Convert.ToDouble(tbWaterLights.Text));
            account.addExpense("Travel", Convert.ToDouble(tbTravel.Text));
            account.addExpense("Phone", Convert.ToDouble(tbPhone.Text));
            account.addExpense("Other", Convert.ToDouble(tbOther.Text));

            Storage store = new Storage();


            //var messageDialog2 = new MessageDialog(account.displayAllExpenses());

            //await messageDialog2.ShowAsync();

            await store.WriteData(account.displayAllExpenses());
            //await store.WriteData("Total Expense " + account.calcTotalExpenses().ToString());


            var messageDialog = new MessageDialog("Expenses added successfully");

           await messageDialog.ShowAsync();
        }
    }
}
