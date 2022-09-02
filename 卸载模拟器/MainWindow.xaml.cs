using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startSimulationButton_Click(object sender, RoutedEventArgs e)
        {
            SimulationWindow simulationWindow1 = new SimulationWindow();
            simulationWindow1.difficulty = difficultyComboBox.SelectedIndex + 1;
            simulationWindow1.Show();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject("http://github.com/FengZhenger/UninstallSimulator");
            MessageBox.Show("仓库地址已复制到您的剪切板。");
        }
    }
}