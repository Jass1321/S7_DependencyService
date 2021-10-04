using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace S7_DependencyService
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item11.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DS_1());
            };
            Item12.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DS_2());
            };
            Item13.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DS_3());
            };
            Item14.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DS_4());
            };
        }
    }
}
