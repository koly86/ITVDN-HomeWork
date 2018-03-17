using System;
using System.Windows;
using HomeWork2.Classes;

namespace HomeWork2
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ConnectDB _connectDb = new ConnectDB();
        private OPUBase1 opuBase1;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var GroupId = Convert.ToInt32(txtbGroupId.Text);
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