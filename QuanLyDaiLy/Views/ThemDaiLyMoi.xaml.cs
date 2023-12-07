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

namespace QuanLyDaiLy.Views
{
    /// <summary>
    /// Interaction logic for ThemDaiLyMoi.xaml
    /// </summary>
    public partial class ThemDaiLyMoi : Window
    {
        public ThemDaiLyMoi()
        {
            InitializeComponent();
        }


        private void BacktoMainWindow()
        {
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BacktoMainWindow();
        }
    }
}
