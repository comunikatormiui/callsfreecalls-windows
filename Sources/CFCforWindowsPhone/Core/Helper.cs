using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFCPortableCommon;

namespace CFCforWindowsPhone.Core
{
    public static class Helper
    {
        public static string GetJson(LoginSend loginSend)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(loginSend);
            return json;
        }

        internal static LoginRequest GetServerRequest(string request)
        {
           return Newtonsoft.Json.JsonConvert.DeserializeObject<LoginRequest>(request);
        }
    }
}