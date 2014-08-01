using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFCPortableCommon
{
    public class LoginRequest
    {
        public bool isRadiumEnabled { get; set; }
        public string[] allAvaliableDIDCountries { get; set; }
        public bool isInMobiEnabled { get; set; }
        public bool isTrialplayEnabled { get; set; }
        public bool isILBCdisabled { get; set; }
        public bool isAdcolonyEnabled { get; set; }
        public string sip_login { get; set; }
        public string defaultAnumber { get; set; }
        public string sip_password { get; set; }
        public bool isHyprEnabled { get; set; }
        public bool isTapjoeEnabled { get; set; }
        public string email { get; set; }
        public string hash { get; set; }
        public int sip_port { get; set; }
        public PhoneNumber[] phoneNumbers { get; set; }
        public string phoneNumber { get; set; }
        public bool isG729disabled { get; set; }
        public string status { get; set; }
        public bool isCfcEnabled { get; set; }
        public bool isLeadboltEnabled { get; set; }
        public bool isFlurryEnabled { get; set; }
        public bool isNewRelicEnabled { get; set; }
        public AuthServer[] authServers { get; set; }
        public bool isAarkiEnabled { get; set; }
        public bool isNativeXEnabled { get; set; }
        public bool isTCPenabled { get; set; }
        public int loggingLevel { get; set; }
        public string destinationsToLockCredit { get; set; }
        public bool isSponsorplayEnabled { get; set; }
        public double balance { get; set; }
        public string sip_ip_address { get; set; }
        public bool isSupersonicEnabled { get; set; }
        public string customerTime { get; set; }

        public LoginRequest()
        {
            isRadiumEnabled = true;
            allAvaliableDIDCountries = new string[] { "Canada", "Puerto Rico", "Czech Republic", "South Korea", "United Kingdom", "United States" };
            isInMobiEnabled = true;
            isTrialplayEnabled = true;
            isILBCdisabled = false;
            isAdcolonyEnabled = true;
            sip_login = "290642";
            defaultAnumber = "97109111110115";
            sip_password = "8549553";
            isHyprEnabled = true;
            isTapjoeEnabled = false;
            email = "amons@mail.ru";
            hash = "899b54273eb9b9c1a9260b4e64d4eb1d";
            sip_port = 50602;
            phoneNumbers = new PhoneNumber[] { new PhoneNumber { defaultNumber = "97109111110115" }, new PhoneNumber { phoneNumber = "883510013200001" } };
            phoneNumber = "883510013200001";
            isG729disabled = false;
            status = "logged_in";
            isCfcEnabled = true;
            isLeadboltEnabled = true;
            isFlurryEnabled = true;
            isNewRelicEnabled = true;
            authServers = new AuthServer[] { new AuthServer() { ip = "208.52.189.225", activeUsers = 31 }, new AuthServer() { ip = "193.108.122.156" }, new AuthServer() { ip = "208.52.161.106", activeUsers = 6 } };
            isAarkiEnabled = true;
            isNativeXEnabled = true;
            isTCPenabled = true;
            loggingLevel = 0;
            destinationsToLockCredit = "380,92";
            isSponsorplayEnabled = true;
            balance = 0.3;
            sip_ip_address = "208.52.189.225";
            isSupersonicEnabled = true;
            customerTime = "20140728122500825";
        }
    }
}