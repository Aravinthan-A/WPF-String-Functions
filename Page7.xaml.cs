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
    /// Interaction logic for Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String Name = txtval.Text;
            String value = "";
            char[] chars= Name.ToCharArray();
            for (int i =chars.Length-1; i >=0 ; i--)
            {
                value += chars[i].ToString();
            }
            txtend.Text = value;
        }
    }
}
