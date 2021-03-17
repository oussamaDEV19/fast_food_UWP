using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace fast_food
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class home_page : Page
    {
        public home_page()
        {
            this.InitializeComponent();
            RPHome.Background = new SolidColorBrush(Colors.Goldenrod);
            MyFrame.Navigate(typeof(home));
        }

        private void RPHome_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            TBHome.Foreground = new SolidColorBrush(Colors.Goldenrod);
        }

        private void RPHome_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            TBHome.Foreground = new SolidColorBrush(Colors.White);
        }

        private void RPHome_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            remove_BK();
            RPHome.Background = new SolidColorBrush(Colors.Goldenrod);
            MyFrame.Navigate(typeof(home));
        }

        private void RPFood_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            remove_BK();
            RPFood.Background = new SolidColorBrush(Colors.Goldenrod);
            MyFrame.Navigate(typeof(food));
        }

        private void TBFood_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            TBFood.Foreground = new SolidColorBrush(Colors.Goldenrod);
        }

        private void TBFood_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            TBFood.Foreground = new SolidColorBrush(Colors.White);
        }

        private void RPOrder_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            remove_BK();
            RPOrder.Background = new SolidColorBrush(Colors.Goldenrod);
            MyFrame.Navigate(typeof(order));
        }



        private void TBOrder_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            TBOrder.Foreground = new SolidColorBrush(Colors.Goldenrod);
        }

        private void TBOrder_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            TBOrder.Foreground = new SolidColorBrush(Colors.White);
        }

        private void RPStatistics_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            remove_BK();
            RPStatistics.Background = new SolidColorBrush(Colors.Goldenrod);
            MyFrame.Navigate(typeof(statistics));
        }

        private void TBStatistics_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            TBStatistics.Foreground = new SolidColorBrush(Colors.Goldenrod);
        }

        private void TBStatistics_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            TBStatistics.Foreground = new SolidColorBrush(Colors.White);
        }

        private void RPExport_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            remove_BK();
            RPExport.Background = new SolidColorBrush(Colors.Goldenrod);
            MyFrame.Navigate(typeof(export));
        }

        private void TBExport_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            TBExport.Foreground = new SolidColorBrush(Colors.Goldenrod);
        }

        private void TBExport_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            TBExport.Foreground = new SolidColorBrush(Colors.White);
        }

        private void RPLogout_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            remove_BK();
            RPLogout.Background = new SolidColorBrush(Colors.Goldenrod);
            Application.Current.Exit();
        }

        private void TBLogout_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            TBLogout.Foreground = new SolidColorBrush(Colors.Goldenrod);
        }

        private void TBLogout_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            TBLogout.Foreground = new SolidColorBrush(Colors.White);
        }

        public void remove_BK()
        {
            RPHome.Background = null;
            RPFood.Background = null;
            RPStatistics.Background = null;
            RPOrder.Background = null;
            RPLogout.Background = null;
            RPExport.Background = null;
        }
    }
}
