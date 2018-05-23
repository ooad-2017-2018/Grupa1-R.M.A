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

namespace AirX
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminPanel : Page
    {
        public AdminPanel()
        {
            this.InitializeComponent();
        }

        private void Navigate(object sender, RoutedEventArgs e)
        {
            if (sender != null)
            {
                NavigationViewItem button = sender as NavigationViewItem;

                if (button.Tag is "home")
                    this.ContentFrame.Navigate(typeof(HomeView));

                if (button.Tag is "add")
                    this.ContentFrame.Navigate(typeof(AdminAddUserView));

                if (button.Tag is "view")
                    this.ContentFrame.Navigate(typeof(AdminViewUsersView));
            }

        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPageNovi));
        }
    }
}
