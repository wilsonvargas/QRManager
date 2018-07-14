using QRManager.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
