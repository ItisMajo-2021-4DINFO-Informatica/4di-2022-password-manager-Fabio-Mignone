using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Notes.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://github.com/Fabio-Mignone");
        }
    }
}