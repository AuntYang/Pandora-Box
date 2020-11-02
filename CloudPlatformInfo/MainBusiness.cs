using System;
using System.Collections.Generic;
using System.Text;
using NLECloudSDK;
using NLECloudSDK.Model;
 
using System.Windows;
using System.Numerics;

namespace CloudPlatformInfo
{
    public class MainBusiness
    {
        static NLECloudAPI SDK = new NLECloudAPI(TempInfo.API_HOST);//用tempinfo类中存储的API_HOST初始化sdk
        
        
        public static ActuatorAddUpdate Began()
        {//开始取号
            var yxh = SDK.Cmds(TempInfo.deviceid, "bool_work",1, TempInfo.Token);
            return null;

        }

        public static ActuatorAddUpdate Stop()
        {//暂停取号
            var yxh = SDK.Cmds(TempInfo.deviceid, "bool_work", 0, TempInfo.Token);
            return null;
        }

        public static ActuatorAddUpdate yourTurn()
        {//叫号
            var yxh = SDK.Cmds(TempInfo.deviceid, "number_down",1,TempInfo.Token);
            return null;
        }

        public static ActuatorAddUpdate fanOpenOrShut(int a)
        {//风扇开关
            var yxh = SDK.Cmds(TempInfo.deviceid, "fan", a, TempInfo.Token);
            return null;
        }

        public static ActuatorAddUpdate heaterOpenOrShut(int a)
        {//加热器开关
            var yxh = SDK.Cmds(TempInfo.deviceid, "LightSwitch", a, TempInfo.Token);
            return null;
        }

        public static ActuatorAddUpdate SteeringLeft(int a)
        {//舵机左转，参数为角度
            var yxh = SDK.Cmds(TempInfo.deviceid, "angle", a, TempInfo.Token);
            return null;
        }

        public static ActuatorAddUpdate SteeringRight(int a)
        {//舵机右转，参数为角度
            var yxh = SDK.Cmds(TempInfo.deviceid, "angle2", a, TempInfo.Token);
            return null;
        }

        public static ActuatorAddUpdate MaximumTemperature(string a)
        {//上限温度修改
            var yxh = SDK.Cmds(TempInfo.deviceid, "upper_Limit", a, TempInfo.Token);
            return null;
        }
        public static ActuatorAddUpdate MinimumTemperature(string a)
        {//下限温度修改
            var yxh = SDK.Cmds(TempInfo.deviceid, "lower_Limit", a, TempInfo.Token);
            return null;
        }

        public static int currentTemp()
        {//当前温度
            var yxh = SDK.GetSensorInfo(TempInfo.deviceid, "currentTemp", TempInfo.Token);
            return int.Parse(yxh.ResultObj.Value.ToString());//注意类型转换
        }
        public static bool WarningLightState()
        {//警示灯状态
            var yxh = SDK.GetSensorInfo(TempInfo.deviceid, "alarm", TempInfo.Token);
            if(int.Parse(yxh.ResultObj.Value.ToString()) == 1 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string FanSwitchState()
        {//风扇开关状态
            var yxh = SDK.GetSensorInfo(TempInfo.deviceid, "fengshan", TempInfo.Token);
            
            return yxh.ResultObj.Value.ToString();
        }

        public static string HeaterSwitch()
        {//加热器开关状态
            var yxh = SDK.GetSensorInfo(TempInfo.deviceid, "deng", TempInfo.Token);
            return yxh.ResultObj.Value.ToString();
        }



    }
}
