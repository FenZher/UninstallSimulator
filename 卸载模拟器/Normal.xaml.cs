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

namespace 卸载模拟器
{
    /// <summary>
    /// Normal.xaml 的交互逻辑
    /// </summary>
    public partial class Normal : Page
    {
        public Window window { get; set; }

        public Normal()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("失败！");
            window.Close();
        }

        private void continueButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("成功！");
            window.Close();
        }
    }
}