using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CFCforWindowsPhone.VM
{
    public class MainVM : BaseVM
    {
        private bool _isCfcImageVisible = true;

        public bool IsCfcImageVisible
        {
            get { return _isCfcImageVisible; }
            set 
            { 
                _isCfcImageVisible = value;
                NotifyPropertyChanged("IsCfcImageVisible");
                NotifyPropertyChanged("CfcImageVisibility");
                NotifyPropertyChanged("PasswordBoxMargin");
                NotifyPropertyChanged("LoginButtonMargin");
            }
        }

        public Visibility CfcImageVisibility
        {
            get { return _isCfcImageVisible ? Visibility.Visible : Visibility.Collapsed; }
        }

        public Thickness PasswordBoxMargin
        {
            get { return _isCfcImageVisible ? new Thickness(0, 36, 0, 0) : new Thickness(0, 0, 0, 0); }
        }

        public Thickness LoginButtonMargin
        {
            get { return _isCfcImageVisible ? new Thickness(0, 72, 0, 0) : new Thickness(0, 0, 0, 0); }
        }

        internal void PasswordTextBoxGotFocus()
        {
            IsCfcImageVisible = false;
        }

        internal void PasswordTextBoxLostFocus()
        {
            IsCfcImageVisible = true;
        }
    }
}