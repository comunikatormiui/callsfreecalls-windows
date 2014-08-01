using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CFCforWindowsPhone.VM;
using CFCPortableCommon;

namespace CFCforWindowsPhone.Core
{
    public class WebProxy
    {
        public LoginRequest loginRequest;
        private MainVM _mainVM;

        public WebProxy(MainVM mainVM)
        {
            _mainVM = mainVM;
        }

        internal void Login(string login, string password)
        {
            string resourceAddress = "http://mac4.ixcglobal.com:8081/login";
            LoginSend loginSend = CreateLoginInfo(login, password);
            PostJsonRequestWebClient(resourceAddress, Helper.GetJson(loginSend));
        }

        #region Ex 2
        void PostJsonRequestWebClient(string resourceAddress, string requestBody)
        {
            WebClient webclient = new WebClient();
            Uri uristring = null;
            //Please replace your webservice url here
            uristring = new Uri(resourceAddress);
            webclient.Headers["ContentType"] = "application/json";
            string WebUrlRegistration = "";

            webclient.UploadStringCompleted += wc_UploadStringCompleted;
            //Post data like this
            webclient.UploadStringAsync(uristring, "POST", requestBody);
        }

        private void wc_UploadStringCompleted(object sender, UploadStringCompletedEventArgs e)
        {
            try
            {

                if (e.Result != null)
                {
                    string responce = e.Result.ToString();
                    loginRequest = Helper.GetServerRequest(responce);
                    _mainVM.LoginInfoRequested();
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
        }

        #endregion

        private static LoginSend CreateLoginInfo(string login, string password)
        {
            LoginSend loginSend = new LoginSend(login, password);

            string ipAddress = FindIPAddress();
            if (string.IsNullOrWhiteSpace(ipAddress))
                loginSend.customer_ip_address = ipAddress;

            ////loginSend.deviceMAC = "B8:E8:56:4A:37:20";
            ////deviceToken = "MPqQ/E98Jt6Ve+fiiHftoZcUme17cZ4pT8wOsXcZ72U=";
            ////deviceType = "x86_64";
            ////iphoneUDID = "424c49454fca8adffedddd536c99c5fb2ee5dd1d";
            ////isBonusNotificationEnabled = "1";
            ////localeIdentifier = "en_US";
            loginSend.newDeviceId = GetDeviceID();
            ////version = "3.0";

            return loginSend;
        }

        private static string GetDeviceID()
        {
            return "AE509FE8-26A0-45E5-909A-55FB07B6B604";

            ////byte[] id = (byte[])Microsoft.Phone.Info.DeviceExtendedProperties.GetValue("DeviceUniqueId");
            ////Guid guidId = Guid.NewGuid();
            ////var id2 = guidId.ToByteArray();
            ////string deviceID = Convert.ToBase64String(id);
            ////return deviceID;
        }

        public static string FindIPAddress()
        {
            List<string> ipAddresses = new List<string>();
            var hostnames = Windows.Networking.Connectivity.NetworkInformation.GetHostNames();
            foreach (var hn in hostnames)
            {
                //IanaInterfaceType == 71 => Wifi
                //IanaInterfaceType == 6 => Ethernet (Emulator)
                if (hn.IPInformation != null &&
                    (hn.IPInformation.NetworkAdapter.IanaInterfaceType == 71
                    || hn.IPInformation.NetworkAdapter.IanaInterfaceType == 6))
                {
                    string ipAddress = hn.DisplayName;
                    ipAddresses.Add(ipAddress);
                }
            }

            if (ipAddresses.Count < 1)
            {
                return null;
            }
            else if (ipAddresses.Count == 1)
            {
                return ipAddresses[0];
            }
            else
            {
                //if multiple suitable address were found use the last one
                //(regularly the external interface of an emulated device)
                //return ipAddresses[ipAddresses.Count - 1];
                return ipAddresses[0];
            }
        }
    }
}