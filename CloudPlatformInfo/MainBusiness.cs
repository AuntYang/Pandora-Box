using System;
using System.Collections.Generic;
using System.Text;
using NLECloudSDK;
using NLECloudSDK.Model;
 
using System.Windows;
using System.Numerics;
using System.Linq;

namespace CloudPlatformInfo
{
    public class MainBusiness
    {
        static NLECloudAPI SDK = new NLECloudAPI(TempInfo.API_HOST);//用tempinfo类中存储的API_HOST初始化sdk


        #region --API模板--
        public static bool OnlineMonitor()
        {   //函数名：OnlineMonitor
            //类型：布尔型
            //作用：查询设备在线情况
            var yxh = SDK.GetDeviceInfo(TempInfo.deviceid, TempInfo.Token);
            if (yxh.ResultObj.IsOnline)
            {
                return true;
            }
            return false;
        }

        public static int ASingleSensorDataQuery_int()
        {   //函数名：ASingleSensorDataQuery_int
            //类型：整型
            //作用：查询单个传感器数据
            //说明：强制类型转换为int32型
            var yxh = SDK.GetSensorInfo(TempInfo.deviceid, "apiTag", TempInfo.Token);
            return Convert.ToInt32(yxh.ResultObj.Value);
        }

        public static string ASingleSensorDataQuery_string()
        {   //函数名：ASingleSensorDataQuery_string
            //类型：字符串型
            //作用：查询单个传感器数据
            //说明：强制类型转换为string型
            var yxh = SDK.GetSensorInfo(TempInfo.deviceid,"apiTag",TempInfo.Token);
            return Convert.ToString(yxh.ResultObj.Value);
        }

        public static bool ASingleSensorDataQuery_bool()
        {   //函数名：ASingleSensorDataQuery_bool
            //类型：布尔型
            //作用：查询单个传感器数据
            //说明：SDK查询返回的传感器数据为object类型，即便返回的数据是布尔型，也需要强制类型转换为string型经过if-else判定后返回给主函数
            var yxh = SDK.GetSensorInfo(TempInfo.deviceid,"apiTag",TempInfo.Token);
            if(Convert.ToString(yxh.ResultObj.Value) == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static ActuatorAddUpdate ExecuteCommand_bool()
        {   //函数名：ASingleSensorDataQuery_string
            //类型：布尔型
            //作用：上传执行器指令
            //说明：使用时仅需要改变apiTag和数据两个参数即可，执行器API大同小异，灵活处理
            var yxh = SDK.Cmds(TempInfo.deviceid,"apiTag","布尔型数据(true/false)",TempInfo.Token);
            return null;
        }

        public static Array AggregationQuery()
        {   //函数名：AggregationQuery
            //类型：void
            //作用：聚合查询传感器数据
            //说明：两个参数，其中一个参数需要构造，在构造函数中填写聚合要求
            SensorDataJuHeQryPagingParas qurry = new SensorDataJuHeQryPagingParas();
            {
                qurry.DeviceID = TempInfo.deviceid;
                qurry.ApiTags = "fan";
                qurry.GroupBy = 2;
                qurry.StartDate = "2020-11-13 18:00:00";
            }
            var yxh = SDK.GroupingSensorDatas(qurry,TempInfo.Token);
            return yxh.ResultObj.DataPoints.ToArray();
        }



        #endregion

        #region --API实例--
        public static ActuatorAddUpdate Began()
        {//开始取号
            var yxh = SDK.Cmds(TempInfo.deviceid, "bool_work", 1, TempInfo.Token);
            return null;
        }

        public static ActuatorAddUpdate Stop()
        {//暂停取号
            var yxh = SDK.Cmds(TempInfo.deviceid, "bool_work", 0, TempInfo.Token);
            return null;
        }

        public static ActuatorAddUpdate yourTurn()
        {//叫号
            var yxh = SDK.Cmds(TempInfo.deviceid, "number_down", 1, TempInfo.Token);
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

        public static ActuatorAddUpdate SteeringLeft(string a)
        {//舵机左转，参数为角度
            var yxh = SDK.Cmds(TempInfo.deviceid, "angle", a, TempInfo.Token);
            return null;
        }

        public static ActuatorAddUpdate SteeringRight(string a)
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
            if (int.Parse(yxh.ResultObj.Value.ToString()) == 1)
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
            var yxh = SDK.GetSensorInfo(TempInfo.deviceid, "fan", TempInfo.Token);
            return yxh.ResultObj.Value.ToString();
        }

        public static string HeaterSwitch()
        {//加热器开关状态
            var yxh = SDK.GetSensorInfo(TempInfo.deviceid, "LightSwitch", TempInfo.Token);
            return yxh.ResultObj.Value.ToString();
        }
        #endregion

        
        public static bool getsensordata()
        {
            SensorDataFuzzyQryPagingParas qurry = new SensorDataFuzzyQryPagingParas();
            {
                qurry.DeviceID = TempInfo.deviceid;
                qurry.ApiTags = TempInfo.Token;
            }
            var yxh = SDK.GetSensorDatas(qurry,TempInfo.Token);
            IEnumerable<SensorDataAddDTO> sensorDTO = yxh.ResultObj.DataPoints;
            List<Dictionary<string, string>> sensorInfo = new List<Dictionary<string, string>>();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            try
            {
                foreach (var l in sensorDTO)
                {
                    foreach (var m in l.PointDTO)
                    {
                        dictionary.Add("value", m.Value.ToString());
                        dictionary.Add("time", m.RecordTime);
                        sensorInfo.Add(dictionary);
                    }
                }
            }
            catch { }

            if (dictionary.Values.ToString() == "1")
            {
                return true;
            }
            return false;
        }


    }
}
