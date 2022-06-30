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
    public sealed partial class Savings : Page
    {
        public Savings()
        {
            this.InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {

            int months = Convert.ToInt32(tbMonths.Text);
            double amount = Convert.ToDouble(tbAmount.Text);

            tbResult.Text = "You need to save R" + savingCalc(months, amount) + " every month to reach your goal of R" + amount.ToString();

        }


        public double savingCalc(int months, double amt) {

            return amt/months;
        }
    }
}
