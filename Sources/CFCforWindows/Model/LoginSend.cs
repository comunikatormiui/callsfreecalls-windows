using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFCforWindows
{
    class login
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

        public login()
        {
            advertisingIdentifier = "6F68A345-0857-4E5C-9DB0-C1362C10564D";
            attemptNumberFirstServer = 0;
            customerTime = DateTime.Now.ToString("yyyyMMddHHmmssFFF");
            customer_ip_address = "109.95.53.216";
            deviceMAC = "B8:E8:56:4A:37:20";
            deviceToken = "MPqQ/E98Jt6Ve+fiiHftoZcUme17cZ4pT8wOsXcZ72U=";
            deviceType = "x86_64";
            email = "amons@mail.ru";
            hash = "bad6c8d711c26e01fd027d342167769f";
            iphoneUDID = "424c49454fca8adffedddd536c99c5fb2ee5dd1d";
            isBonusNotificationEnabled = "1";
            localeIdentifier = "en_US";
            newDeviceId = "B762B5DB-0C4B-4FB2-BD23-432417A1B8B5";
            password = "1";
            version = "3.0";
        }

        public string GetJson()
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            return json;
        }

        public string GetStringData2()
        {
            StringBuilder sb = new StringBuilder();

            ////sb.AppendLine("2014-07-09 10:34:32.459 CallsFreeCalls[2415:5f03] >>>>>>>>>>>>>>>> login sent:{");
            ////sb.AppendLine("login sent:{");
            sb.Append("sent:{");
            sb.Append("    advertisingIdentifier = \"5872E93E-132A-40EB-AB2D-FF3ECF31660D\";");
            sb.Append("    customerTime = 20140709103432457;");
            sb.Append("    \"customer_ip_address\" = \"81.33.33.28\";");
            sb.Append("    deviceMAC = \"02:00:00:00:00:00\";");
            sb.Append("    deviceToken = \"MPqQ/E98Jt6Ve+fiiHftoZcUme17cZ4pT8wOsXcZ72U=\";");
            sb.Append("    deviceType = iPhone4s;");
            sb.Append("    email = \"alex@ixc.ua2\";");
            sb.Append("    hash = 5b10983b574a2caf99eabece66aed2a3;");
            sb.Append("    iphoneUDID = 2b5be11f31898d6a0c11eea1fb8cfc1584e85b70;");
            sb.Append("    isBonusNotificationEnabled = 1;");
            sb.Append("    localeIdentifier = \"ru_UA\";");
            sb.Append("    newDeviceId = \"25B4255E-AD21-4592-B4C3-871B596FF790\";");
            sb.Append("    password = 1;");
            sb.Append("}");

            var res = sb.ToString();
            return res;
        }

        public string GetStringData()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(">>>>>>>>>>>>>>>> login sent:{");

            sb.AppendLine(string.Format("    advertisingIdentifier = {0};", advertisingIdentifier));
            sb.AppendLine(string.Format("    customerTime = {0};", customerTime));
            sb.AppendLine(string.Format("    \"customer_ip_address\" = \"{0}\";", customer_ip_address));
            sb.AppendLine(string.Format("    deviceMAC = \"{0}\";", deviceMAC));
            sb.AppendLine(string.Format("    deviceType = \"{0}\";", deviceType));
            sb.AppendLine(string.Format("    email = \"{0}\";", email));
            sb.AppendLine(string.Format("    hash = {0};", "bad6c8d711c26e01fd027d342167769f"));
            sb.AppendLine(string.Format("    iphoneUDID = {0};", iphoneUDID));
            sb.AppendLine(string.Format("    isBonusNotificationEnabled = {0};", isBonusNotificationEnabled));
            sb.AppendLine(string.Format("    localeIdentifier = \"{0}\";", localeIdentifier));
            sb.AppendLine(string.Format("    newDeviceId = \"{0}\";", newDeviceId));
            sb.AppendLine(string.Format("    password = {0};", password));

            sb.AppendLine("}");

            var res = sb.ToString();
            return res;
        }
    }
}
