using TipsAndTricks.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipsAndTricks.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StringFormatPage : ContentPage
    {
        public StringFormatPage()
        {
            InitializeComponent();
            this.BindingContext = new StringFormatPageViewModelPage();
        }
    }
}