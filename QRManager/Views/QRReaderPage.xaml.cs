using QRManager.ViewModels;
using ZXing.Net.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using ZXing.Net.Maui.Controls;

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

        private void ZXingScannerView_OnScanResult(object sender, BarcodeDetectionEventArgs e)
        {
            foreach (var barcode in e.Results) 
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    MessagingCenter.Send(barcode.Value, "ScanQRCode");
                });
            }            
        }
    }
}
