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
    public sealed partial class Residential : Page
    {

        MainPage mp = new MainPage();

        public Residential()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mp.residentialStatus = "R";
            //Window.Current.Close();

            //MessageDialog showDialog = new MessageDialog(mp.residentialStatus.ToString(), "Exit");
            //showDialog.ShowAsync();

            FindParent<Frame>(this.Frame)?.Navigate(typeof(MainPage));

        }

        private void btnHouse_Click(object sender, RoutedEventArgs e)
        {
           
            mp.residentialStatus = "H";

            //MessageDialog showDialog = new MessageDialog(mp.residentialStatus.ToString());
            //showDialog.ShowAsync();
            FindParent<Frame>(this.Frame)?.Navigate(typeof(MainPage));
        }


        public static T FindParent<T>(DependencyObject dependencyObject) where T : DependencyObject
        {
            var parentObject = VisualTreeHelper.GetParent(dependencyObject);

            if (parentObject == null) return null;

            var parent = parentObject as T;
            return parent ?? FindParent<T>(parentObject);
        }
    }
}
