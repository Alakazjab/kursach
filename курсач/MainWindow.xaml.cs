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

namespace курсач
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        /* private void Button_Click(object sender, RoutedEventArgs e)
         {         
             var host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
             foreach (var ip in host.AddressList)
             {
                 if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                 {
                     tb1.Text = ip.ToString();
                 }
             }
         }*/
    }
}
