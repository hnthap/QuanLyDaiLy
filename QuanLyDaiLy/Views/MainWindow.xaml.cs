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
        private HomeForm StartupForm;

        public MainWindow()
        {
            InitializeComponent();
            SwitchToHomeForm();
        }

        private void SwitchToHomeForm()
        {
            ContentContainer.Children.Clear(); // Xóa form hiện tại
            currentForm = new HomeForm(); // Tạo một instance mới của HomeForm
            ContentContainer.Children.Add(currentForm); // Thêm form vào ContentContainer
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SwitchToHomeForm();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ContentContainer.Children.Clear(); // Xóa form hiện tại
            currentForm = new ThongTinDaiLy(); // Tạo một instance mới của ThongTinDaiLy
            ContentContainer.Children.Add(currentForm); // Thêm form vào ContentContainer
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            ContentContainer.Children.Clear(); // Xóa form hiện tại
            currentForm = new PhieuXuatHang(); // Tạo một instance mới của PhieuXuatHang
            ContentContainer.Children.Add(currentForm); // Thêm form vào ContentContainer
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            ContentContainer.Children.Clear(); // Xóa form hiện tại
            currentForm = new PhieuThuTien(); // Tạo một instance mới của PhieuThuTien
            ContentContainer.Children.Add(currentForm); // Thêm form vào ContentContainer
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            ContentContainer.Children.Clear(); // Xóa form hiện tại
            currentForm = new BaoCaoCongNo(); // Tạo một instance mới của BaoCaoCongNo
            ContentContainer.Children.Add(currentForm); // Thêm form vào ContentContainer
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            ContentContainer.Children.Clear(); // Xóa form hiện tại
            currentForm = new BaoCaoDoanhThu(); // Tạo một instance mới của BaoCaoDoanhThu
            ContentContainer.Children.Add(currentForm); // Thêm form vào ContentContainer
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}