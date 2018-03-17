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
using HomeWork2.Classes;

namespace HomeWork2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OPUBase1 opuBase1 = null;
        ConnectDB _connectDb = new ConnectDB();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int GroupId = Convert.ToInt32(txtbGroupId.Text);
                opuBase1 = _connectDb.GetGroupName(GroupId);
                Grid.DataContext = opuBase1;

            }
            catch (Exception exception)
            {
               MessageBox.Show($@"{exception}");
            }
        }
    }
}
