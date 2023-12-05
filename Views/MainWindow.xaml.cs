using QuanLyDaiLy.Views;
using System;
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
        private void SwitchToThemDaiLy()
        {
            ContentContainer.Children.Clear(); // Xóa form hiện tại
            currentForm = new ThemDaiLy(); // Tạo một instance mới của ThemDaiLy
            ContentContainer.Children.Add(currentForm); // Thêm form vào ContentContainer
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
            SwitchToThemDaiLy();
        }
    }
}