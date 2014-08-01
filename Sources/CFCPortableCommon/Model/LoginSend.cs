using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFCPortableCommon
{
    public class LoginSend
    {
        public string advertisingIdentifier { get; set; }
        public int attemptNumberFirstServer { get; set; }
        public string customerTime { get; set; }
        public string customer_ip_address { get; set; }
        public string deviceMAC { get; set; }
        public string deviceToken { get; set; }
        public string deviceType { get; set; }
        public string email { get; set; }
        public string hash { get; set; }
        public string iphoneUDID { get; set; }
        public string isBonusNotificationEnabled { get; set; }
        public string localeIdentifier { get; set; }
        public string newDeviceId { get; set; }
        public string password { get; set; }
        public string version { get; set; }

        public LoginSend(string userLogin, string userPassword)
        {
            advertisingIdentifier = "6F68A345-0857-4E5C-9DB0-C1362C10564D";
            attemptNumberFirstServer = 0;
            customerTime = DateTime.Now.ToString("yyyyMMddHHmmssFFF");
            customer_ip_address = "109.95.53.216";
            deviceMAC = "B8:E8:56:4A:37:20";
            deviceToken = "MPqQ/E98Jt6Ve+fiiHftoZcUme17cZ4pT8wOsXcZ72U=";
            deviceType = "x86_64";
            email = userLogin;
            hash = "bad6c8d711c26e01fd027d342167769f";
            iphoneUDID = "424c49454fca8adffedddd536c99c5fb2ee5dd1d";
            isBonusNotificationEnabled = "1";
            localeIdentifier = "en_US";
            newDeviceId = "B762B5DB-0C4B-4FB2-BD23-432417A1B8B5";
            password = userPassword;
            version = "3.0";
        }
    }
}