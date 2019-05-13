using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace QRManager.ViewModels
{
    public class QRGeneratorViewModel : ViewModelBase
    {
        private string teamCode;
        public string TeamCode
        {
            get { return teamCode; }
            set { SetProperty(ref teamCode, value); }
        }

        private string entryContent;
        public string EntryContent
        {
            get { return entryContent; }
            set { SetProperty(ref entryContent, value); }
        }

        public ICommand GenerateQRCodeCommand => new Command(GenerateQRCode);

        private void GenerateQRCode()
        {
            if (EntryContent == string.Empty)
            {
                TeamCode = EntryContent;
            }
        }
    }
}
