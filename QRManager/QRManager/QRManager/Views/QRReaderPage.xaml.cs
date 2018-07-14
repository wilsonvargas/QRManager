using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace QRManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRReaderPage : ContentPage
    {
        public QRReaderPage()
        {
            InitializeComponent();
            Scan();
        }

        private ZXingDefaultOverlay overlay;
        private ZXingScannerView zxing;

        private async void Scan()
        {
            var scanPage = new ZXingScannerPage();

            scanPage.OnScanResult += (result) =>
            {
                // Stop scanning
                scanPage.IsScanning = false;

                // Pop the page and show the result
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    await DisplayAlert("Scanned Barcode", result.Text, "OK");
                });
            };

            // Navigate to our scanner page
            await Navigation.PushAsync(scanPage);
        }
    }
}
