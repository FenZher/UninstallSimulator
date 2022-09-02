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

namespace 卸载模拟器
{
    /// <summary>
    /// SimulationWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SimulationWindow : Window
    {
        public int difficulty { get; set; }

        public SimulationWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (difficulty == 1)
            {
                Easy easy = new Easy();
                easy.window = this;
                simulationFrame.Navigate(easy);
            }
            else if (difficulty == 2)
            {
                Normal normal = new Normal();
                normal.window = this;
                simulationFrame.Navigate(normal);
            }
            else
            {
                return;
            }
        }
    }
}