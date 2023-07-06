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
    /// Interaction logic for Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        public Page6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String main = txtval.Text;
            String Aim = txtfrom.Text;
            bool Data = main.EndsWith(Aim);
            if (Data)
            {
                MessageBox.Show("The Characters Ends with" + (" ") + Aim);
            }
            else
            {
                MessageBox.Show("The Characters Not Ends with" + (" ") + Aim);
            }
        }
    }
}
