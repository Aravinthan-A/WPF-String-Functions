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

namespace String_Function
{
    /// <summary>
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String main = txtval.Text;
            String Aim = txtfrom.Text;
            bool Data = main.Contains(Aim);
            if (!Data)
            {
                MessageBox.Show("The Characters Not contains" +(" ")+ Aim);
            }
            else
            {
                MessageBox.Show("The Characters contains" +(" ")+ Aim);
            }
        }
    }
}
