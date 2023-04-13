using QRManager.Models;
using QRManager.Views;
using System.Collections.Generic;

namespace QRManager.ViewModels
{
    public class MasterPageViewModel : ViewModelBase
    {
        public MasterPageViewModel()
        {
            Items = new List<MasterPageItem>();
            Load();
        }

        public List<MasterPageItem> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        private List<MasterPageItem> _items;

        private void Load()
        {
            Items.Add(new MasterPageItem
            {
                Title = "QR Reader",
                Icon = "qrcodescan.png",
                Target = typeof(QRReaderPage)
            });
            Items.Add(new MasterPageItem
            {
                Title = "QR Generator",
                Icon = "qrcode.png",
                Target = typeof(QRGeneratorPage)
            });
        }
    }
}
