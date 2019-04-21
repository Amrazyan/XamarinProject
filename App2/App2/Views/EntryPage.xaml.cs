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
            Button2.Clicked += OpenNewPage;
        }

        private async void OpenNewPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyPage());
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            CrossLocalNotifications.Current.Show("Success Registere", $"{Email.Text } {Environment.NewLine} {Password.Text}",1);
        }
    }
}