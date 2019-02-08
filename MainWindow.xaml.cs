/* Austin McKee
 * Feb 6, 2019
 * Hello World my first Program, understand most of it, help with understanding .cs?
 */
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

namespace _184905HelloWorld
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

        private void btnGreeting_Click(object sender, RoutedEventArgs e)
        {
            String name = txtName.Text;
            message.Content = "Hello, " + name;
        }
    }
}
