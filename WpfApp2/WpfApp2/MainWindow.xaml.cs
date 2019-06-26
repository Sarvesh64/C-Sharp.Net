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

namespace WpfApp2
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
            txt_fullname.Text = txt_fname.Text + " " + txt_lname.Text; 
        }

        private void Txt_fname_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Txt_fname_TextChanged(object sender, TextChangedEventArgs e)
        {
            txt_fullname.Text = txt_fname.Text;
        }

        private void Txt_lname_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Txt_lname_TextChanged(object sender, TextChangedEventArgs e)
        {
            txt_fullname.Text = txt_fname.Text + " " + txt_lname.Text;
        }
    }
}
