using NLECloudSDK;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CloudPlatformInfo
{
    public static class TempInfo
    {//存储登录后的accesstoken
        public static String API_HOST = "http://api.nlecloud.com";
        public static string Username;
        //ApplicationSettings.Get("ApiHost");
        public static int deviceid = 143670;//设备标识
        public static String Token;//登录成功后返回的Token
    }
}
