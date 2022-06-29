using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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

            tbIncome.Text = acc.getIncome().ToString();
            //tbExpense.Text = expenseList;
            tbExpense.Text = store.ReadDataCustom("Vehicle");
            //tbCar.Text = store.ReadDataCustom("Vehicle");
            tbCar.Text = store.ReadData();
            //tbExpense.Text = "MOney: 123\nMOney: 123\nMOney: 123\nMOney: 123";
        }
    }
}
