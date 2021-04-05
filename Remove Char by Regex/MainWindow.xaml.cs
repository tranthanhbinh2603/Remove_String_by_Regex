using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Remove_Char_by_Regex
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

        private void Run_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text = "";
            Regex reg = new Regex(@"\d{4}-\d{2}-\d{2}\ \d{2}:\d{2}:\d{2}\ INFO\ .{5}\ -\ \[ToolCheckAccount\]\ - (?<Res>.*?)$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Multiline | RegexOptions.Singleline);
            foreach (Match item in reg.Matches(tbInput.Text))
            {
                foreach (Capture i in item.Groups["Res"].Captures)
                {
                    tbOutput.Text += i.ToString() + "\n";
                }
            }
        }
    }
}
