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

namespace AirX
{

    public sealed partial class RegistracijaView : UserControl
    {
        private User user;

        internal User User { get => user; set => user = value; }

        public RegistracijaView()
        {
            this.InitializeComponent();
            lbGender.Items.Add("Male");
            lbGender.Items.Add("Female");

        }

        private void OnClearClick(object sender, RoutedEventArgs e)
        {
            var tb = new List<TextBox>();
            FindTextBoxex(this, tb);
            foreach (var x in tb)
            {
                x.Text = String.Empty;
            }
        }

        public event RoutedEventHandler RegClicked;
        protected void OnRegClick(RoutedEventArgs e)
        {
            var handler = RegClicked;
            if (handler != null)
                handler(this, e);
        }

        private void Registracija_Click(object sender, RoutedEventArgs e)
        {
            var tb = new List<TextBox>();
            FindTextBoxex(this, tb);
            Boolean fieldsEmpty = false;
            foreach (var x in tb)
            {
                if (x.Text == string.Empty)
                    fieldsEmpty = true;
            }

            if (!fieldsEmpty && tbPassword.Text == tbPasswordConfirmation.Text
                && tbEmailAdress.Text == tbEmailConfirmation.Text)
            {
                Boolean gender;
                if (lbGender.SelectedItem.ToString() == "Male")
                    gender = false;
                else
                    gender = true;

                DateTime xxxxxx = DateTime.Today; // =====> cdpDateOfBirth
                this.User = new User(tbGivenName.Text, tbSurname.Text, gender, xxxxxx, tbPlaceOfBirth.Text, tbNationality.Text,
                                    tbPhysicalAdress.Text, tbPhoneNumber.Text, tbUsername.Text, tbEmailAdress.Text, tbPassword.Text);

                OnRegClick(e);
                
            }
        }

        private void FindTextBoxex(object uiElement, IList<TextBox> foundOnes)
        {
            if (uiElement is TextBox)
            {
                foundOnes.Add((TextBox)uiElement);
            }
            else if (uiElement is Panel)
            {
                var uiElementAsCollection = (Panel)uiElement;
                foreach (var element in uiElementAsCollection.Children)
                {
                    FindTextBoxex(element, foundOnes);
                }
            }
            else if (uiElement is UserControl)
            {
                var uiElementAsUserControl = (UserControl)uiElement;
                FindTextBoxex(uiElementAsUserControl.Content, foundOnes);
            }
            else if (uiElement is ContentControl)
            {
                var uiElementAsContentControl = (ContentControl)uiElement;
                FindTextBoxex(uiElementAsContentControl.Content, foundOnes);
            }
        }
    }
    
}

