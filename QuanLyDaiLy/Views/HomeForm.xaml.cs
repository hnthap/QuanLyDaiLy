using BLL;
using DTO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyDaiLy.Views
{
    /// <summary>
    /// Interaction logic for HomeForm.xaml
    /// </summary>
    public partial class HomeForm : UserControl
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        // Envoke after clicking the Log In button
		private void btnLogin_Click(object sender, RoutedEventArgs e)
		{
            string name = txtUser.Text;
            string password = txtPass.Password;
            if (UserAccountBLL.TryLogIn(name, password))
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("Đăng nhập thành công!!");
                builder.AppendLine($"Tên người dùng: {UserAccountBLL.CurrentAccount!.UserAccountName}");
                builder.AppendLine($"Email: {UserAccountBLL.CurrentAccount!.UserAccountEmail}");
                builder.AppendLine($"Mật khẩu: {UserAccountBLL.CurrentAccount!.UserAccountPassword}");
                builder.AppendLine($"Cấp: {UserAccountBLL.CurrentRole!.UserRoleName}");
                builder.AppendLine("Quyền:");
                foreach (UserRight right in UserAccountBLL.CurrentRights)
                {
                    builder.AppendLine($" + {right.UserRightName}");
                }
                MessageBox.Show(builder.ToString());
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hay tên tài khoản rồi bạn ơi.");
            }
        }
    }
}
