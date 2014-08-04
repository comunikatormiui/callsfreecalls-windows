using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CFCforWindowsPhone.Core;
using CFCPortableCommon;

namespace CFCforWindowsPhone.VM
{
    public class MainVM : BaseVM
    {
        private bool _isCfcImageVisible = true;
        private string _login = string.Empty;
        private string _password = string.Empty;
        private bool _isLoginFocused;
        private bool _isPasswordFocused;
        private WebProxy _web;

        public string Login
        {
            get { return _login; }
            set { _login = value; NotifyPropertyChanged("Login"); }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; NotifyPropertyChanged("Password"); }
        }

        public string LoginText
        {
            get { return string.IsNullOrWhiteSpace(_login) ? "E-mail Address" : _login; }
        }

        public Visibility LoginTextVisibility
        {
            get { return _isLoginFocused || !string.IsNullOrWhiteSpace(_login) ? Visibility.Collapsed : Visibility.Visible; }
        }

        public Visibility PasswordTextVisibility
        {
            get { return _isPasswordFocused || !string.IsNullOrWhiteSpace(_password) ? Visibility.Collapsed : Visibility.Visible; }
        }

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

        public MainVM()
        {
            _web = new WebProxy(this);
#if Debug
            Login = "amons@mail.ru";
            Password = "1";
#endif
        }

        internal void PasswordTextBoxGotFocus()
        {
            IsCfcImageVisible = false;
            _isPasswordFocused = true;
            NotifyPropertyChanged("PasswordTextVisibility");
        }

        internal void PasswordTextBoxLostFocus()
        {
            IsCfcImageVisible = true;
            _isPasswordFocused = false;
            NotifyPropertyChanged("PasswordTextVisibility");
        }

        internal void LoginTextBoxGotFocus()
        {
            IsCfcImageVisible = false;
            _isLoginFocused = true;
            NotifyPropertyChanged("LoginText");
            NotifyPropertyChanged("Login");
            NotifyPropertyChanged("LoginTextVisibility");
        }

        internal void LoginTextBoxLostFocus()
        {
            IsCfcImageVisible = true;
            _isLoginFocused = false;
            NotifyPropertyChanged("LoginText");
            NotifyPropertyChanged("Login");
            NotifyPropertyChanged("LoginTextVisibility");
        }

        internal void LoginExecute()
        {
            //TestLoginRequest();
            _web.Login(Login, Password);
        }

        //private void TestLoginRequest()
        //{
        //    string request = "{\"isRadiumEnabled\":true,\"allAvaliableDIDCountries\":[\"Canada\",\"Puerto Rico\",\"Czech Republic\",\"South Korea\",\"United Kingdom\",\"United States\"],\"isInMobiEnabled\":true,\"isTrialplayEnabled\":true,\"isILBCdisabled\":false,\"isAdcolonyEnabled\":true,\"sip_login\":\"290642\",\"defaultAnumber\":\"97109111110115\",\"sip_password\":\"8549553\",\"isHyprEnabled\":true,\"isTapjoeEnabled\":false,\"email\":\"amons@mail.ru\",\"hash\":\"899b54273eb9b9c1a9260b4e64d4eb1d\",\"sip_port\":50602,\"phoneNumbers\":[{\"defaultNumber\":\"97109111110115\"},{\"phoneNumber\":\"883510013200001\"}],\"phoneNumber\":\"883510013200001\",\"isG729disabled\":false,\"status\":\"logged_in\",\"isCfcEnabled\":true,\"isLeadboltEnabled\":true,\"isFlurryEnabled\":true,\"isNewRelicEnabled\":true,\"authServers\":[{\"ip\":\"208.52.189.225\",\"activeUsers\":31},{\"ip\":\"193.108.122.156\"},{\"ip\":\"208.52.161.106\",\"activeUsers\":6}],\"isAarkiEnabled\":true,\"isNativeXEnabled\":true,\"isTCPenabled\":true,\"loggingLevel\":0,\"destinationsToLockCredit\":\"380,92\",\"isSponsorplayEnabled\":true,\"balance\":0.3,\"sip_ip_address\":\"208.52.189.225\",\"isSupersonicEnabled\":true,\"customerTime\":\"20140728122500825\"}";

        //    LoginRequest r = Helper.GetServerRequest(request);
        //}

        internal void LoginInfoRequested()
        {
            MessageBox.Show("Status: " + _web.loginRequest.status);
        }
    }
}