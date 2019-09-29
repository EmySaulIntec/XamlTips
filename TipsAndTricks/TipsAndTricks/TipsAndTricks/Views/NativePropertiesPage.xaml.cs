using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipsAndTricks.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NativePropertiesPage : ContentPage
    {
        public NativePropertiesPage()
        {
            InitializeComponent();
            picker.Items.Add("One");
            picker.Items.Add("Red");
            picker.Items.Add("Later");
            picker.Items.Add("Foot");

            IEnumerable<string> items = new string[] { "One", "Red", "Later", "Foot" };

            myList.ItemsSource = items;
        }
    }
}