using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
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
    public sealed partial class Vehicle : Page
    {
        public Vehicle()
        {
            this.InitializeComponent();
        }

        VehicleClass vc = new VehicleClass();
        Storage store = new Storage();

        private async void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (tbModel.Text == "")
            {

                var errorDialog = new MessageDialog("Vehicle make and model cannot be empty");

                await errorDialog.ShowAsync();
            }
            else if (tbPrice.Text == "")
            {

                var errorDialog = new MessageDialog("Vehicle purchase price cannot be empty");

                await errorDialog.ShowAsync();
            }
            else if (tbDeposit.Text == "")
            {

                var errorDialog = new MessageDialog("Vehicle deposit cannot be empty");

                await errorDialog.ShowAsync();
            }
            else if (tbInterest.Text == "")
            {
                var errorDialog = new MessageDialog("Vehicle interest cannot be empty");
                await errorDialog.ShowAsync();
            }
            else if (tbInsurance.Text == "")
            {
                var errorDialog = new MessageDialog("Vehicle insurance cannot be empty");
                await errorDialog.ShowAsync();
            }



            vc.MakeAndModel = tbModel.Text;
            vc.PurchasePrice = Convert.ToDouble(tbPrice.Text);
            vc.Deposit = Convert.ToDouble(tbDeposit.Text);
            vc.InterestRate = Convert.ToDouble(tbInterest.Text);
            vc.InsurancePremium = Convert.ToDouble(tbInsurance.Text);

            await store.WriteData(vc.showVehicle());

            var messageDialog = new MessageDialog("Vehicle added successfully");

            await messageDialog.ShowAsync();

            ShowNewView();
        }


        private int currentViewId = ApplicationView.GetForCurrentView().Id;
        private async void ShowNewView()
        {
            CoreApplicationView newView = CoreApplication.CreateNewView();
            int newViewId = 0;
            await newView.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                Frame frame = new Frame();
                frame.Navigate(typeof(MainPage), null);
                Window.Current.Content = frame;
                Window.Current.Activate();
                newViewId = ApplicationView.GetForCurrentView().Id;
            });

            await ApplicationViewSwitcher.SwitchAsync(newViewId, currentViewId, ApplicationViewSwitchingOptions.ConsolidateViews);
        }


    }
}
