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
using System.Net.Http;

namespace CalcDesktopCodeInside
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

        private async void buttom_click(object sender, RoutedEventArgs e)
        {
         
        var client = new HttpClient();
        var result = await client.GetStringAsync("http://localhost:44324/average?nums=4&nums=12&nums=15&nums=2&nums=29");
            txtbox.Text += "Average: " + result + "/r";

        result = await client.GetStringAsync("http://localhost:44324/smallest?nums=4&nums=12&nums=15&nums=2&nums=29");
            txtbox.Text += "smallest: " + result + "/r";

        result = await client.GetStringAsync("http://localhost:44324/largest?nums=4&nums=12&nums=15&nums=2&nums=29");
            txtbox.Text += "largest: " + result + "/r";
        }
    }
}
