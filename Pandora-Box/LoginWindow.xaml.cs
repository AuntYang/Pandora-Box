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

        
        #endregion


        private void Button_Click_login(object sender, RoutedEventArgs e)
        {//“登录”按钮

            #region --账号密码判空提示--
            if (username.Text == "")
            {
                Growl.Warning("账号不能为空！");
            };
            if(password.Password == "")
            {
                Growl.Warning("密码不能为空！");
            }
            #endregion


        }

        private void Button_about_Click(object sender, RoutedEventArgs e)
        {//“关于我们”按钮
            HandyControl.Controls.MessageBox.Info("开发者：\nAndroid：胡凯元\nSTM32：张乐\nC#：付准", "你好！用户");
        }
    }
}
