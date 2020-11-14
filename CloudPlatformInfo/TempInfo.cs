using NLECloudSDK;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CloudPlatformInfo
{
    public static class TempInfo
    {//存储登录后的各种信息
        public static String API_HOST = "http://api.nlecloud.com";
        public static string LoginMsg;//登录失败原因
        public static string Username;//用户名
        //ApplicationSettings.Get("ApiHost");
        public static int deviceid = 143670;//设备标识
        public static String Token;//登录成功后返回的Token
        //public static bool online;//设备在线标志，仅在设备在线时进行其他查询动作，避免null
    }
}
