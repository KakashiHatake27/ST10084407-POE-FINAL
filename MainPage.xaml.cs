using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PoePartThreeFinal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();


        }

        //private async Task<bool> OpenPageAsWindowAsync(Type t)
        //{

        //    var view = CoreApplication.CreateNewView();
        //    int id = 0;

        //    await view.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
        //    {
        //        var frame = new Frame();
        //        frame.Navigate(t, null);
        //        Window.Current.Content = frame;
        //        Window.Current.Activate();
        //        id = ApplicationView.GetForCurrentView().Id;
        //    });

        //    return await ApplicationViewSwitcher.TryShowAsStandaloneAsync(id);
        //}

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (!args.IsSettingsSelected)
            {
                NavigationViewItem item = args.SelectedItem as NavigationViewItem;

                switch (item.Tag.ToString())
                {
                    case "pgHome": ContentFrame.Navigate(typeof(Home)); break;
                    case "pgVehicle": ContentFrame.Navigate(typeof(Vehicle)); break;
                    case "pgResidential": ContentFrame.Navigate(typeof(Residential)); break;
                    case "pgIncome": ContentFrame.Navigate(typeof(Income)); break;
                    case "pgExpense": ContentFrame.Navigate(typeof(Expenses)); break;
                }
            }
        }

        private async void ExitPrompt() {

            MessageDialog showDialog = new MessageDialog("Are you sure you want to close the application?", "Exit");
            showDialog.Commands.Add(new UICommand("Yes")
            {
                Id = 0
            });
            showDialog.Commands.Add(new UICommand("No")
            {
                Id = 1
            });
            showDialog.DefaultCommandIndex = 0;
            showDialog.CancelCommandIndex = 1;
            var result = await showDialog.ShowAsync();
            if ((int)result.Id == 0)
            {
               Application.Current.Exit();
            }
            

        }

        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            //ContentFrame.Navigate(typeof(LoadingScreen));

            //Thread.Sleep(5000);
            
            ContentFrame.Navigate(typeof(Home));

        }

        private void NavView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            if (ContentFrame.CanGoBack)
                ContentFrame.GoBack();
        }

        private void NavigationViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ExitPrompt();
        }
    }
}
