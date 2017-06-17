using QRManager.Models;
using QRManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRManager.ViewModels
{
    public class MasterPageViewModel : ViewModelBase
    {
        private List<MasterPageItem> _items;

        public List<MasterPageItem> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        public MasterPageViewModel()
        {
            Items = new List<MasterPageItem>();
            Load();
        }

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
