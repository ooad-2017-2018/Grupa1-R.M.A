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
    
    public sealed partial class MainPageNovi : Page
    {
        Popup Loginpopup;

        public MainPageNovi()
        {
            this.InitializeComponent();
            Loginpopup = new Popup();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            this.ContentFrame.Navigate(typeof(HomeView));
        }

        private void OnLoginClick (object sender, RoutedEventArgs e)
        {
            if (!Loginpopup.IsOpen)
            {
                

                LoginPopup login = new LoginPopup();

                Loginpopup.Child= login;

                Loginpopup.HorizontalOffset = (Window.Current.Bounds.Width)/2- 100;
                Loginpopup.VerticalOffset = (Window.Current.Bounds.Height)/2 -150;


                this.IsHitTestVisible = false;
                this.Opacity = 0.1;

                this.Loginpopup.Closed += Loginpopup_Closed;

                Loginpopup.IsOpen = true;
            }
        }

        private void Loginpopup_Closed(object sender, object e)
        {
            this.IsHitTestVisible = true;
            this.Opacity = 1;
            switch((Loginpopup.Child as LoginPopup).end)
            {
                case 0:
                    if((Loginpopup.Child as LoginPopup).username == "admin")
                    {
                        this.Frame.Navigate(typeof(AdminPanel));
                    }
                    break;
                case 1:
                    break;
                case 2:
                    this.ContentFrame.Navigate(typeof(UserRegistracijaView));
                    break;
            }     
        }

        private void Navigate (object sender, RoutedEventArgs e)
        {
            if (sender != null)
            {
                NavigationViewItem button = sender as NavigationViewItem;

                if (button.Tag is "home")
                    this.ContentFrame.Navigate(typeof(HomeView));

            }
            
        }
        

    }
}
