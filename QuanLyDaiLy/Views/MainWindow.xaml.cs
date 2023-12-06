using QuanLyDaiLy.Views;
using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyDaiLy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserControl currentForm;

        public MainWindow()
        {
            InitializeComponent();
            SwitchToHomeForm(); // Chuyển đổi sang HomeForm khi khởi tạo MainWindow
        }

        private void SwitchToHomeForm()
        {
            ContentContainer.Children.Clear(); // Xóa form hiện tại
            currentForm = new HomeForm(); // Tạo một instance mới của HomeForm
            ContentContainer.Children.Add(currentForm); // Thêm form vào ContentContainer
        }

        private void SwitchToForm1()
        {
            ContentContainer.Children.Clear(); // Xóa form hiện tại
            currentForm = new ThongTinDaiLy(); // Tạo một instance mới của ThongTinDaiLy
            ContentContainer.Children.Add(currentForm); // Thêm form vào ContentContainer
        }

        private void SwitchToForm2()
        {
            ContentContainer.Children.Clear(); // Xóa form hiện tại
            currentForm = new TimKiemDaiLy(); // Tạo một instance mới của TimKiemDaiLy
            ContentContainer.Children.Add(currentForm); // Thêm form vào ContentContainer
        }

        private void SwitchToForm3()
        {
            ContentContainer.Children.Clear(); // Xóa form hiện tại
            currentForm = new PhieuXuatHang(); // Tạo một instance mới của PhieuXuatHang
            ContentContainer.Children.Add(currentForm); // Thêm form vào ContentContainer
        }

        private void SwitchToForm4()
        {
            ContentContainer.Children.Clear(); // Xóa form hiện tại
            currentForm = new PhieuThuTien(); // Tạo một instance mới của PhieuThuTien
            ContentContainer.Children.Add(currentForm); // Thêm form vào ContentContainer
        }

        private void SwitchToForm5()
        {
            ContentContainer.Children.Clear(); // Xóa form hiện tại
            currentForm = new BaoCaoCongNo(); // Tạo một instance mới của BaoCaoCongNo
            ContentContainer.Children.Add(currentForm); // Thêm form vào ContentContainer
        }

        private void SwitchToForm6()
        {
            ContentContainer.Children.Clear(); // Xóa form hiện tại
            currentForm = new BaoCaoDoanhThu(); // Tạo một instance mới của BaoCaoDoanhThu
            ContentContainer.Children.Add(currentForm); // Thêm form vào ContentContainer
        }

        private void SwitchToThemDaiLyMoi()
        {
            ThemDaiLyMoi themDaiLyMoi = new ThemDaiLyMoi();
            themDaiLyMoi.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SwitchToHomeForm(); // Chuyển đổi sang HomeForm khi người dùng nhấp vào nút Home
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SwitchToForm1(); // Chuyển đổi sang Form1 khi người dùng nhấp vào nút Form1
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SwitchToForm2(); // Chuyển đổi sang Form2 khi người dùng nhấp vào nút Form2
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SwitchToForm3(); // Chuyển đổi sang Form2 khi người dùng nhấp vào nút Form3
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SwitchToForm4(); // Chuyển đổi sang Form2 khi người dùng nhấp vào nút Form4
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SwitchToForm5(); // Chuyển đổi sang Form2 khi người dùng nhấp vào nút Form5
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            SwitchToForm6(); // Chuyển đổi sang Form2 khi người dùng nhấp vào nút Form6
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            SwitchToThemDaiLyMoi();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.Margin = new Thickness(0, 0, -10, 0); // Thay đổi giá trị Margin âm

            button.Background = Brushes.LightBlue; // Đặt màu nền là lightblue
            button.BorderBrush = Brushes.Black; // Đặt màu viền là đen
            button.BorderThickness = new Thickness(1); // Đặt độ dày viền là 1 pixel

            button.Foreground = Brushes.Black; // Đặt màu chữ là đen
            button.FontSize = button.FontSize + 2; // Tăng kích thước lên 2
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.Margin = new Thickness(0); // Khôi phục giá trị Margin ban đầu

            button.Background = Brushes.Transparent; // Đặt màu nền là trong suốt
            button.BorderBrush = Brushes.Transparent; // Đặt màu viền là trong suốt
            button.BorderThickness = new Thickness(0); // Đặt độ dày viền là 0 pixel

            button.Foreground = Brushes.White; // Đặt màu chữ là trắng
            button.FontSize = button.FontSize - 2; // Giảm kích thước đi 2
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}