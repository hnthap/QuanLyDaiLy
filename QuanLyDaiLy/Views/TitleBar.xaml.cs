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
    /// Interaction logic for TitleBar.xaml
    /// </summary>
    public partial class TitleBar : UserControl
    {
        public TitleBar()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc muốn đóng chương trình?", "Xác nhận đóng chương trình", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = Window.GetWindow(this);

            if (mainWindow.WindowState == WindowState.Maximized)
            {
                mainWindow.WindowState = WindowState.Normal;
            }
            else
            {
                mainWindow.WindowState = WindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = Window.GetWindow(this);
            mainWindow.WindowState = WindowState.Minimized;
        }
    }
}
