using QRManager.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace QRManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
            BindingContext = new MasterPageViewModel();
        }

        public ListView ListView { get { return navigationDrawerList; } }
    }
}
