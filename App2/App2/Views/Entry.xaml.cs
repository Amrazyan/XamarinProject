using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Plugin.LocalNotifications;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Entry : ContentPage
    {
        public Entry()
        {
            InitializeComponent();
            Title = "Ask your name";
            Button1.Clicked += Button1_Clicked;
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            CrossLocalNotifications.Current.Show("Ժաննա Հովհաննիսյան", "0",1);
            textToShow.Text = inputBox.Text;
        }
    }
}