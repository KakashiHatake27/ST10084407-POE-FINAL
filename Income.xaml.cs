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
    public sealed partial class Income : Page
    {
        public Income()
        {
            this.InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account();
            Storage store = new Storage();

            account.setIncome(Convert.ToDouble(tbIncome.Text));

            string IncomeData = "Income " + account.getIncome().ToString();

            await store.WriteData(IncomeData);

            var messageDialog = new MessageDialog("Income added successfully");

            await messageDialog.ShowAsync();

        }
    }
}
