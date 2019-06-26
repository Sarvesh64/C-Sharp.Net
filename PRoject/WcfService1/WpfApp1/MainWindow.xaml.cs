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
            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();

            label.Content = obj.GetData(10);

            //obj.getdataasync(10);
            //obj.getdatacompleted += obj_getdtaacppmleted;

            //obj.begingetdata(10,delegate(IAsyncResult ar)
                //{
                //obj.endgetdata(ar)
                //},null);
        }
    }
}
