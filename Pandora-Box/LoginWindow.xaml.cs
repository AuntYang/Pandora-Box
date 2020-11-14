using HandyControl.Controls;
using HandyControl.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using NLECloudSDK;
using CloudPlatformInfo;
using System.Diagnostics;

namespace Pandora_Box
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : System.Windows.Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        #region --窗口功能函数--

        
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {//用户体验优化：自由点击事件
            try
            {
                this.DragMove();
            }
            catch { }
        }
        

        private void txt_Pwd_KeyDown(object sender, KeyEventArgs e)
        {//用户体验优化：按回车登录
            switch (e.Key)
            {
                case Key.Enter:
                    Button_Click_login(Button_login, null);
                    break;

                default:
                    break;
            }
        }

        private void Button_Click_exit(object sender, RoutedEventArgs e)
        {//退出按钮
            Application.Current.Shutdown();
        }

        private void Button_about_Click(object sender, RoutedEventArgs e)
        {//“关于我们”按钮
            HandyControl.Controls.MessageBox.Info("开发者：\nAndroid：胡凯元\nSTM32：张乐\nC#：付准", "你好！用户");
        }

        #endregion

        #region --登录按钮点击事件--
        private void Button_Click_login(object sender, RoutedEventArgs e)
        {//“登录”按钮

            #region --账号密码判空提示--
            if(username.Text == ""|| password.Password == "")
            {
                if (username.Text == "")
                {
                    Growl.Warning("账号不能为空！");
                }
                if (password.Password == "")
                {
                    Growl.Warning("密码不能为空！");
                }
            }
            else
            {
                LoginAuthentication();
            }
            /*
            if (username.Text == "")
            {
                Growl.Warning("账号不能为空！");
            }
            else
            {
                LoginAuthentication();
            }
            if(password.Password == "")
            {
                Growl.Warning("密码不能为空！");
            }
            else
            {
                LoginAuthentication();
            }
            */

            #endregion


        }
        #endregion

        #region --登录验证函数--
        private void LoginAuthentication()
        {
            
            AccountLoginDTO accountLoginDTO = new AccountLoginDTO();//实例化
            {//将账号密码传入云平台做登录验证
                accountLoginDTO.Account = username.Text;
                accountLoginDTO.Password = password.Password;
            }
            bool islogin = ForLogin.UserLogin(accountLoginDTO);
            if (islogin)
            {//返回值判断登录是否成功
                HandyControl.Controls.MessageBox.Info("登陆成功，欢迎使用本系统！", "登录成功");//登录成功提示框
                TempInfo.Username = ForLogin.UserInfo(accountLoginDTO);
                new MainWindow().Show();//显示系统主窗口
                this.Close();//本窗口关闭
            }
            else
            {
                HandyControl.Controls.MessageBox.Info(TempInfo.LoginMsg, "登录失败");//登录失败提示框
            }
        }
        #endregion

        #region --忘记密码&注册账号--

        /// <summary>
        /// 受窗体自由拖动影响无法点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForgotPassword_Click(object sender, RoutedEventArgs e)
        {//忘记密码
            System.Windows.MessageBox.Show("点击成功", "成功");
            Hyperlink link = sender as Hyperlink;
            Process.Start(new ProcessStartInfo(link.NavigateUri.AbsoluteUri));
        }

        private void RegisteredAccount_Click(object sender, RoutedEventArgs e)
        {//注册账号
            System.Windows.MessageBox.Show("点击成功","成功");
            Hyperlink link = sender as Hyperlink;
            Process.Start(new ProcessStartInfo(link.NavigateUri.AbsoluteUri));
        }
        #endregion

    }
}
