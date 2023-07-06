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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String Npath = Rootpath();


            //Page1 page1=new Page1();
            // frmcon.Content=page1;
        }
        private String Rootpath()
        {
            String Filepath = System.Environment.CurrentDirectory;
            int Indexn = Filepath.IndexOf("bin");
            String Removei = Filepath.Remove(Indexn);
            return Removei;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page2 page2 = new Page2();
            frmcon.Content = page2;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Page3 page3 = new Page3();
            frmcon.Content = page3;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Page4 page4 = new Page4();
            frmcon.Content = page4;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Page5 page5 = new Page5();
            frmcon.Content = page5;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Page6 page6 = new Page6();
            frmcon.Content = page6;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Page7 page7 = new Page7();
            frmcon.Content = page7;
        }
    }
}
