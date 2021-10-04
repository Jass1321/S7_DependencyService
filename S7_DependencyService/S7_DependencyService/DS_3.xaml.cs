using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace S7_DependencyService
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DS_3 : ContentPage
    {
        public DS_3()
        {
            InitializeComponent();
        }
        private async void btnScannerQR_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                scanner.TopText = "By: Jassyra Espinoza";
                var result = await scanner.Scan();
                if (result!=null)
                {
                    txtResultado.Text = result.Text;
                }
            }catch(Exception ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "OK");
            }
        }
    }
}