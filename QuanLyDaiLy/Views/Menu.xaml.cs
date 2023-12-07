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
    /// Interaction logic for Menu.xaml
    /// </summary>
    /// 
    public partial class Menu : UserControl
    {
        // Sự kiện khi nút Button được nhấp
        public event RoutedEventHandler ButtonClicked;
        // Sự kiện khi nút Button1 được nhấp
        public event RoutedEventHandler Button1Clicked;
        // Sự kiện khi nút Button2 được nhấp
        public event RoutedEventHandler Button2Clicked;
        // Sự kiện khi nút Button3 được nhấp
        public event RoutedEventHandler Button3Clicked;
        // Sự kiện khi nút Button4 được nhấp
        public event RoutedEventHandler Button4Clicked;
        // Sự kiện khi nút Button5 được nhấp
        public event RoutedEventHandler Button5Clicked;
        // Sự kiện khi nút Button6 được nhấp
        public event RoutedEventHandler Button6Clicked;
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Kích hoạt sự kiện ButtonClicked
            ButtonClicked?.Invoke(this, e);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            // Kích hoạt sự kiện Button1Clicked
            Button1Clicked?.Invoke(this, e);
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            // Kích hoạt sự kiện Button2Clicked
            Button2Clicked?.Invoke(this, e);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            // Kích hoạt sự kiện Button3Clicked
            Button3Clicked?.Invoke(this, e);
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            // Kích hoạt sự kiện Button4Clicked
            Button4Clicked?.Invoke(this, e);
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            // Kích hoạt sự kiện Button5Clicked
            Button5Clicked?.Invoke(this, e);
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            // Kích hoạt sự kiện Button6Clicked
            Button6Clicked?.Invoke(this, e);
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.Margin = new Thickness(10, 0, -10, 0); // Thay đổi giá trị Margin âm
            button.Width = button.Width + 30;
            button.Height = button.Height + 20;

            button.Background = Brushes.LightBlue; // Đặt màu nền là lightblue
            button.BorderBrush = Brushes.Black; // Đặt màu viền là đen

            button.BorderThickness = new Thickness(1); // Đặt độ dày viền là 1 pixel
            button.Foreground = Brushes.Black; // Đặt màu chữ là đen
        }
        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.Margin = new Thickness(0); // Khôi phục giá trị Margin ban đầu
            button.Width = button.Width - 30;
            button.Height = button.Height - 20;

            button.Background = Brushes.Transparent; // Đặt màu nền là trong suốt
            button.BorderBrush = Brushes.Transparent; // Đặt màu viền là trong suốt
            button.BorderThickness = new Thickness(0); // Đặt độ dày viền là 0 pixel

            button.Foreground = Brushes.White; // Đặt màu chữ là trắng
        }
    }
}
