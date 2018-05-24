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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminViewUsersView : Page
    {
        public AdminViewUsersView()
        {
            this.InitializeComponent();
            
        }

        IMobileServiceTable<User> userTableObj = App.MobileService.GetTable<User>();

        private List<User> useri;

        internal List<User> Useri { get => useri; set => useri = value; }
        string lastQuery;

        private async void NameQuerySubmitedAsync(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {

            lastQuery = sender.QueryText;
            await PopulateListViewAsync(lastQuery);

        }

        private async System.Threading.Tasks.Task PopulateListViewAsync(string query)
        {
            Useri = await userTableObj.Where(User => (User.GivenName + User.Surname).Contains(query)).ToListAsync();

            lwUseri.ItemsSource = Useri;

            if (Useri.Count == 0)
            {
                MessageDialog msgDialogError = new MessageDialog("Nije pronadjen niti jedan user");
                await msgDialogError.ShowAsync();
            }
        }



        private async void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ContentDialog contDialogDelete = new ContentDialog
            {
                Title = "Delete user ?",
                Content = "Are you sure you want to delete this user, you will be able to bring the user back?",
                CloseButtonText = "Cancel",
                PrimaryButtonText = "Delete"
            };
            ContentDialogResult result = await contDialogDelete.ShowAsync();
            if(result == ContentDialogResult.Primary)
            {
                await userTableObj.DeleteAsync(lwUseri.SelectedItem as User);
                Useri = await userTableObj.Where(User => (User.GivenName + User.Surname).Contains(lastQuery)).ToListAsync();

                lwUseri.ItemsSource = Useri;
            }
        }
    }
}
