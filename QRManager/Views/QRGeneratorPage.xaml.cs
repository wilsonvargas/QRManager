using QRManager.ViewModels;
using System;
using ZXing.Net.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

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
