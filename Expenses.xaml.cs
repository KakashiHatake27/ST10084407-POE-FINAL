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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            account.addExpense("Monthly Tax", Convert.ToDouble(tbMonthlyTax.Text));
            account.addExpense("Groceries", Convert.ToDouble(tbGroceries.Text));
            account.addExpense("Water and lights", Convert.ToDouble(tbWaterLights.Text));
            account.addExpense("Travel", Convert.ToDouble(tbTravel.Text));
            account.addExpense("Phone", Convert.ToDouble(tbPhone.Text));
            account.addExpense("Other", Convert.ToDouble(tbOther.Text));

            var messageDialog = new MessageDialog("Expenses added successfully");

            messageDialog.ShowAsync();
        }
    }
}
