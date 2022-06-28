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
    public sealed partial class renting : Page
    {
        Account account = new Account();
        

        public renting()
        {
            this.InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            double rental=Convert.ToDouble(tbRental.Text);
            //account.Rental = rental;
            account.setRental(rental);

            var messageDialog = new MessageDialog("Rental added successfully");

            messageDialog.ShowAsync();

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
