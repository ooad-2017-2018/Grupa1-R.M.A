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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace AirX
{
    public sealed partial class LoginPopup : UserControl
    {

        public string username, password;
        public Int32 end;

        public LoginPopup()
        {
            this.InitializeComponent();
            
        }

        private void ButtonReturnClick(object o, RoutedEventArgs e)
        {
            end = 2;

            Popup p = this.Parent as Popup;

            if (p != null)
            {
                p.IsOpen = false;
            }
        }

        private void LoginBut_Click(object sender, RoutedEventArgs e)
        {
            username=UserName.Text;
            password = Password.Text;
            end = 0;

            Popup p = this.Parent as Popup;

            if (p != null)
            {
                p.IsOpen = false;
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            end = 2;

            Popup p = this.Parent as Popup;

            if (p != null)
            {
                p.IsOpen = false;
            }
        }
    }
}
