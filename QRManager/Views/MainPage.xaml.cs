using QRManager.Models;
using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace QRManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            Flyout = masterPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(QRGeneratorPage)));
            masterPage.ListView.ItemSelected += OnItemSelected;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.Target));
                masterPage.ListView.SelectedItem = null;
            }
        }
    }
}
