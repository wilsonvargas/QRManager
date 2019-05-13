using QRManager.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace QRManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRGeneratorPage : ContentPage
    {
        public QRGeneratorPage()
        {
            InitializeComponent();
            BindingContext = new QRGeneratorViewModel();
        }             
    }
}
