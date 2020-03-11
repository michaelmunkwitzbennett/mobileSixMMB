using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobileSixMMB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButton1Clicked(object sender, EventArgs args)
        {
            Page page = (Page)Activator.CreateInstance(typeof(ActivityOnePage));
            await Navigation.PushAsync(page);
        }
        private async void OnButton2Clicked(object sender, EventArgs args)
        {
            Page page = (Page)Activator.CreateInstance(typeof(ActivityTwoPage));
            await Navigation.PushAsync(page);
        }
        private async void OnButton3Clicked(object sender, EventArgs args)
        {
            Page page = (Page)Activator.CreateInstance(typeof(ActivityThreePage));
            await Navigation.PushAsync(page);
        }
    }
}
