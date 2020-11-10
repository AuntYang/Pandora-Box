using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
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
using HandyControl.Controls;
using LiveCharts;
using LiveCharts.Wpf;
using Painter;


namespace Pandora_Box
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {

        #region --参数设置--
        public SeriesCollection SeriesCollection { get; set; }//存放
        public List<string> Labels { get; set; } = new List<string> { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };//横坐标,存放图表x轴数据

        private int[] temp = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };//横坐标初始值

        UserControl1 UserControl1 = new UserControl1();//实例化进度条导航窗口
        UserControl2 UserControl2 = new UserControl2();
        UserControl3 UserControl3 = new UserControl3();
        UserControl4 UserControl4 = new UserControl4();

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;

            //柱状图
            MariaSeriesVisibility = true;
            CharlesSeriesVisibility = true;
            JohnSeriesVisibility = false;
            DataContext = this;

            //函数执行
            livechart();
            RadarMapDraw();
            RoseDiagramDraw();

            this.Container.Children.Add(UserControl1);

            userinfo.Text = "欢迎用户:" + TempInfo.Username;//显示当前用户信息

        }

        #endregion

        #region --定时器--
        DispatcherTimer time;//实例化一个定时器

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            time = new DispatcherTimer();
            time.Interval = TimeSpan.FromSeconds(1);
            time.Tick += CurrentTimeBlock;
            time.Tick += linestart;
            //time.Tick += RadarMapDraw;
            //time.Tick += RoseDiagramDraw;
            time.Start();

        }
        #endregion

        #region --柱状图--

        private bool _mariaSeriesVisibility;
        private bool _charlesSeriesVisibility;
        private bool _johnSeriesVisibility;
        public bool MariaSeriesVisibility
        {
            get { return _mariaSeriesVisibility; }
            set
            {
                _mariaSeriesVisibility = value;
                OnPropertyChanged("MariaSeriesVisibility");
            }
        }

        public bool CharlesSeriesVisibility
        {
            get { return _charlesSeriesVisibility; }
            set
            {
                _charlesSeriesVisibility = value;
                OnPropertyChanged("CharlesSeriesVisibility");
            }
        }

        public bool JohnSeriesVisibility
        {
            get { return _johnSeriesVisibility; }
            set
            {
                _johnSeriesVisibility = value;
                OnPropertyChanged("JohnSeriesVisibility");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion

        #region --折线图--
        public void livechart()
        {//创建折线图函数
            LineSeries mylineseries = new LineSeries();
            mylineseries.Title = "当前温度";
            //mylineseries.LineSmoothness = 0;//折线图直线形式
            //mylineseries.PointGeometry = null;//折线图的无点样式
            Labels = new List<string> { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            mylineseries.Values = new ChartValues<int>(temp);
            myAxisX.Separator.Step = 1;//设置轴间距，设置为0.5时数值1分为两格
            //myAxisY.Separator.Step = 1;
            SeriesCollection = new SeriesCollection { };
            SeriesCollection.Add(mylineseries);
            linestart(null, null);
            DataContext = this;
        }

        public void linestart(object sender, EventArgs e)
        {//折线图绘制函数

            Labels.Add(DateTime.Now.ToString("HH:mm:s"));
            Labels.RemoveAt(0);

            SeriesCollection[0].Values.Add(MainBusiness.currentTemp());
            SeriesCollection[0].Values.RemoveAt(0);
        }
        #endregion

        #region --雷达图--
        private void RadarMapDraw()
        {
            //if (RadarTab.IsSelected == true)
            //{
                RadarControl rdc = new RadarControl() { MoreGraphics = true, AreaBrush = Brushes.Black, RadarNetBrush = Brushes.Black, AreaPointBrush = Brushes.Orange, BorderBrush = Brushes.Gray, RadarNetBrushes = new List<Brush> { Brushes.LightSkyBlue, Brushes.Violet } };
                this.RadarMap.Children.Clear();
                this.RadarMap.Children.Add(rdc);
                List<RadarObj>[] lst = { CrData(), CrData() };
                rdc.SetData(lst);
           // }
           // else
            //{
                //this.RadarMap.Children.Clear();
           /// }

        }
        #endregion

        #region --玫瑰图--
        private void RoseDiagramDraw()
        {
                NightingaleRose rdc = new NightingaleRose();
                this.RoseDiagram.Children.Clear();
                this.RoseDiagram.Children.Add(rdc);
                rdc.SetData(CrData()); 
        }

        #endregion

        #region --状态显示--
        private void CurrentTimeBlock(object sender, EventArgs e)
        {//显示当前时间和状态信息
            CurrentTime.Text = "当前时间：" + DateTime.Now;
            CurrentTemperatureDisplay.Text = MainBusiness.currentTemp() + "℃";//显示当前室温
            TemperatureInstrument.Value = MainBusiness.currentTemp();//仪表显示当前室温
            TemperatureInstrument.Text = MainBusiness.currentTemp().ToString() + "℃";
            TemperatureInstrument.FontSize = 30;
            if (MainBusiness.WarningLightState())
            {//显示警示灯开关状态
                WarningLightState.Text = "开";
            }
            else
            {
                WarningLightState.Text = "关";
            }
            if (MainBusiness.FanSwitchState() == "1")
            {
                FanSwitchState.Text = "开";//显示风扇开关状态
            }
            else
            {
                FanSwitchState.Text = "关";//显示风扇开关状态
            }
            if (MainBusiness.HeaterSwitch() == "1")
            {
                StateTheHeater.Text = "开";//显示加热器开关状态
            }
            else
            {
                StateTheHeater.Text = "关";//显示加热器开关状态
            }
            //FanSwitchState.Text = MainBusiness.FanSwitchState();//显示风扇开关状态
            //测试用：
            //System.Windows.MessageBox.Show(MainBusiness.FanSwitchState(),"test");

            //StateTheHeater.Text = MainBusiness.HeaterSwitch();//显示加热器开关状态

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
            Growl.Success("打开风扇指令发送成功");
        }

        private void FanControlClearance_Click(object sender, RoutedEventArgs e)
        {//控制风扇关按钮
            MainBusiness.fanOpenOrShut(0);
            Growl.Success("关闭风扇指令发送成功");
        }

        private void HeaterControlOpen_Click(object sender, RoutedEventArgs e)
        {//控制加热器开按钮
            MainBusiness.heaterOpenOrShut(1);
            Growl.Success("打开加热器指令发送成功");
        }

        private void HeaterControlShut_Click(object sender, RoutedEventArgs e)
        {//控制加热器关按钮

            MainBusiness.heaterOpenOrShut(0);
            Growl.Success("关闭加热器指令发送成功");
        }

        private void SteeringLeft_Click(object sender, RoutedEventArgs e)
        {//舵机左转按钮
            MainBusiness.SteeringLeft(SteeringGearRotationAngle.Text);//传入角度
            Growl.Success("舵机转向指令发送成功，角度：" + SteeringGearRotationAngle.Text + "°");
        }

        private void SteeringGearRight_Click(object sender, RoutedEventArgs e)
        {//舵机右转按钮
            MainBusiness.SteeringRight(SteeringGearRotationAngle.Text);//传入角度
            Growl.Success("舵机转向指令发送成功，角度：" + SteeringGearRotationAngle.Text + "°");
        }

        private void ChartToSave_Click(object sender, RoutedEventArgs e)
        {//保存图表按钮
            
        }

        private void ReadChart_Click(object sender, RoutedEventArgs e)
        {//读取图表按钮

        }

        #endregion

        #region --模拟数据--
        Random rdm = new Random();

        private List<RadarObj> CrData()
        {
            List<RadarObj> list = new List<RadarObj>();
            list.Add(new RadarObj() { Name = "A", DataValue = rdm.Next(20, 100) });
            list.Add(new RadarObj() { Name = "B", DataValue = rdm.Next(20, 100) });
            list.Add(new RadarObj() { Name = "C", DataValue = rdm.Next(20, 100) });
            list.Add(new RadarObj() { Name = "D", DataValue = rdm.Next(20, 100) });
            list.Add(new RadarObj() { Name = "E", DataValue = rdm.Next(20, 100) });
            list.Add(new RadarObj() { Name = "F", DataValue = rdm.Next(20, 100) });
            list.Add(new RadarObj() { Name = "F", DataValue = rdm.Next(20, 100) });
            return list;
        }

        #endregion

        #region --进度条按钮--
        private void PreviousStep_Click(object sender, RoutedEventArgs e)
        {
            this.Container.Children.Clear();
            if (stepbar.StepIndex == 1)
            {
                this.Container.Children.Add(UserControl1);
            }
            if (stepbar.StepIndex == 2)
            {
                this.Container.Children.Add(UserControl2);
            }
            if (stepbar.StepIndex == 3)
            {
                this.Container.Children.Add(UserControl3);
            }
            pagenum.Text = "当前页数：" + stepbar.StepIndex;
            stepbar.StepIndex -= 1;
            
        }

        private void NextStep_Click(object sender, RoutedEventArgs e)
        {
            
            this.Container.Children.Clear();
            if(stepbar.StepIndex == 0)
            {
                this.Container.Children.Add(UserControl2);
            }
            if (stepbar.StepIndex == 1)
            {
                this.Container.Children.Add(UserControl3);
            }
            if (stepbar.StepIndex == 2)
            {
                this.Container.Children.Add(UserControl4);
            }
            if (stepbar.StepIndex == 3)
            {
                SystemInfo.IsSelected = true;
            }
            pagenum.Text = "当前页数：" + stepbar.StepIndex;
            stepbar.StepIndex += 1;
        }

        #endregion

    }
}
