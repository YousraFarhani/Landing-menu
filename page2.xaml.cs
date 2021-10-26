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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for page2.xaml
    /// </summary>
    public partial class page2 : Page
    {
        public page2()
        {
            InitializeComponent();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page3());
        }
         private void Button_Click1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page3());
        }
    }
}
