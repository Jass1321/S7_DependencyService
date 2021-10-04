using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S7_DependencyService
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DS_4 : ContentPage
    {
        public DS_4()
        {
            InitializeComponent();
            var stack = new StackLayout();


            // Text-to-Speech
            var speak = new Button
            {
                Text = "Hello, Forms !",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
            speak.Clicked += (sender, e) =>
            {
                DependencyService.Get<ITextToSpeech>().Speak("Hello from Xamarin Forms");
            };
            stack.Children.Add(speak);

            Content = speak;
        }
    }
}