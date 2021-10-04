using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;


namespace S7_DependencyService
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DS_1 : ContentPage
    {
        public DS_1()
        {
            InitializeComponent();
        }

        private async void BtnClicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync(txtTexto.Text, new SpeechOptions
            {
                Volume = (float)sliderVolumen.Value
            });
        }
    }
}