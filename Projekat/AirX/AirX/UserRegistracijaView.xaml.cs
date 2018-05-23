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
using AirX.Model;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AirX
{

    public sealed partial class UserRegistracijaView : Page
    {
        RegistracijaView reg;
        IMobileServiceTable<User> userTableObj = App.MobileService.GetTable<User>();

        public UserRegistracijaView()
        {
            this.InitializeComponent();
            reg = new RegistracijaView();

            this.regControl.Content = reg;
            reg.RegClicked += ControlRegClicked;
        }

        private void ControlRegClicked (object sender, RoutedEventArgs e)
        {
            try
            {

                User user;
                user = reg.User;

                user.UserType = "end_user"; 

                userTableObj.InsertAsync(user);
                MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog studenta.");
                msgDialog.ShowAsync();
                
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                msgDialogError.ShowAsync();
            }
        }

    }
}
