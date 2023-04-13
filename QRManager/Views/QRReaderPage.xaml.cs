using QRManager.ViewModels;
using ZXing.Net.Mobile.Forms;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace QRManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRReaderPage : ContentPage
    {
        public QRReaderPage()
        {
            InitializeComponent();
            BindingContext = new QRReaderViewModel();
        }

        private void ZXingScannerView_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                MessagingCenter.Send(result.Text, "ScanQRCode");
            });
        }
    }
}
