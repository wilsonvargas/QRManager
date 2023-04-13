using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace QRManager.ViewModels
{
    public class QRReaderViewModel : ViewModelBase
    {
        private string result;
        public string Result
        {
            get { return result; }
            set { SetProperty(ref result, value); }
        }

        public QRReaderViewModel()
        {
            MessagingCenter.Subscribe<string>(this, "ScanQRCode", (teamCodeRead) =>
            {
                Result = teamCodeRead;
            });
        }
    }
}
