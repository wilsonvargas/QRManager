namespace QRManager.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new QRManager.App());
        }
    }
}
