using BLL;
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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private MainWindow mainWindow;

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

		private void btnDangKy_Click(object sender, RoutedEventArgs e)
		{
            string name = txtUser.Text;
            string email = txtEmail.Text;
            string password = txtPass.Password;
            string confirmedPassword = txtCPass.Password;

            if (UserAccountBLL.TrySignUp(name, email, password, confirmedPassword))
            {
                MessageBox.Show("Successfully signed up. Please log in again.");
            }
            else
            {
                MessageBox.Show("You can't sign up.");
            }
            this.Close();
		}
	}
}
