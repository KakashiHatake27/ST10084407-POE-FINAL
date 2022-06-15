using System;
using System.Threading;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PoePartThreeFinal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoadingScreen : Page
    {
        public LoadingScreen()
        {
            this.InitializeComponent();

            Thread.Sleep(3000);
        }

        private async void _img_bg_ImageOpened(object sender, RoutedEventArgs e)
        {
            //
            
        }

        private async Task<bool> OpenPageAsWindowAsync(Type t)
        {

            var view = CoreApplication.CreateNewView();
            int id = 0;

            await view.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var frame = new Frame();
                frame.Navigate(t, null);
                Window.Current.Content = frame;
                Window.Current.Activate();
                id = ApplicationView.GetForCurrentView().Id;
            });

            return await ApplicationViewSwitcher.TryShowAsStandaloneAsync(id);
        }

        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //Thread.Sleep(3000);
            //OpenPageAsWindowAsync(typeof(MainPage));

            //Thread.Sleep(3000);
            //Window.Current.Close();

        }
    }
}
