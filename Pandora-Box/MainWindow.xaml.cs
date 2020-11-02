using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;
using System.Windows.Threading;
using CloudPlatformInfo;

namespace Pandora_Box
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            userinfo.Text = "欢迎用户:" + TempInfo.Username;//显示当前用户信息
        }

        #region --定时器--
        DispatcherTimer time;//实例化一个定时器

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            time = new DispatcherTimer();
            time.Interval = TimeSpan.FromSeconds(1);
            time.Tick += CurrentTimeBlock;
            //time.Tick += livechart;
            time.Start();

        }
        #endregion

        #region --状态显示--
        private void CurrentTimeBlock(object sender , EventArgs e)
        {//显示当前时间和状态信息
            CurrentTime.Text = "当前时间："+DateTime.Now;
            CurrentTemperatureDisplay.Text = MainBusiness.currentTemp()+"℃";//显示当前室温
            TemperatureInstrument.Value = MainBusiness.currentTemp();//仪表显示当前室温
            if(MainBusiness.WarningLightState())
            {//显示警示灯开关状态
                WarningLightState.Text = "开";
            }
            else
            {
                WarningLightState.Text = "关";
            }
            FanSwitchState.Text = MainBusiness.FanSwitchState();//显示风扇开关状态
            StateTheHeater.Text = MainBusiness.HeaterSwitch();//显示加热器开关状态
        }
        #endregion

        #region --界面优化--
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {//用户体验优化：自由点击事件
            try
            {
                this.DragMove();
            }
            catch { }
        }
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {//用户体验优化：新大陆图标点击事件
            Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "http://www.nlecloud.com/";
            proc.Start();
        }
        #endregion

        #region --交互窗体--
        public async void MessageTips(string message, object sender, RoutedEventArgs e)
        {//对话框
            var sampleMessageDialog = new SampleMessageDialog
            {
                Message = { Text = message }
            };
            await DialogHost.Show(sampleMessageDialog, "RootDialog");
        }
        public void SnackbarAll(string message)
        {//底部提示框
         //调用说明：各个事件都能够调用本方法显示出提示框，函数参数为需要提示的文字
            var messageQueue = Snackbar.MessageQueue;
            Task.Factory.StartNew(() => messageQueue.Enqueue(message));
        }
        #endregion

        #region --右上角按钮--
        private void about_Click(object sender, RoutedEventArgs e)
        {//“关于我们”按钮点击事件
            //HandyControl.Controls.MessageBox.Info("开发者：\nAndroid：胡凯元\nSTM32：张乐\nC#：付准", "你好！用户");
            MessageTips("本项目由以下同学完成：\nSTM32：  张乐\nAndroid：胡凯元\nC#：         付准", sender, e);
        }
        private void logout_Click(object sender, RoutedEventArgs e)
        {//“退出登录”按钮点击事件
            SnackbarAll("你好!用户");
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
        private void exit_Click(object sender, RoutedEventArgs e)
        {//“退出软件”按钮点击事件
            Application.Current.Shutdown();
        }


        #endregion

        #region --相关设置选项卡--
        private void TemperatureThresholdSettings_Click(object sender, RoutedEventArgs e)
        {//修改上下限温度阈值确定按钮
            MainBusiness.MaximumTemperature(UpperLimitTemperature.Text);//上传上限温度
            MainBusiness.MinimumTemperature(LowerLimitTemperature.Text);//上传下限温度
        }

        private void ResetTemperatureThreshold_Click(object sender, RoutedEventArgs e)
        {//温度阈值重置按钮
            UpperLimitTemperature.Text = "";
            LowerLimitTemperature.Text = "";
        }
        #endregion

        #region --控制按钮--

        private void FanControlOpen_Click(object sender, RoutedEventArgs e)
        {//控制风扇开按钮
            MainBusiness.fanOpenOrShut(1);
        }

        private void FanControlClearance_Click(object sender, RoutedEventArgs e)
        {//控制风扇关按钮
            MainBusiness.fanOpenOrShut(0);
        }

        private void HeaterControlOpen_Click(object sender, RoutedEventArgs e)
        {//控制加热器开按钮
            MainBusiness.heaterOpenOrShut(1);
        }

        private void HeaterControlShut_Click(object sender, RoutedEventArgs e)
        {//控制加热器关按钮
            MainBusiness.heaterOpenOrShut(0);
        }

        private void SteeringLeft_Click(object sender, RoutedEventArgs e)
        {//舵机左转按钮
            MainBusiness.SteeringLeft(int.Parse(SteeringGearRotationAngle.Text));//传入角度
        }

        private void SteeringGearRight_Click(object sender, RoutedEventArgs e)
        {//舵机右转按钮
            MainBusiness.SteeringRight(int.Parse(SteeringGearRotationAngle.Text));//传入角度
        }
        #endregion
    }
}
