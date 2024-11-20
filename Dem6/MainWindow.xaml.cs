using Dem6.ApplicationData;
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

namespace Dem6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppConnect.modelOdb = new TurizmEntities();
            AppFrame.FrameMain = MainFrm;
            MainFrm.Navigate(new Hotel());
        }

        private void AddHotel_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new MainPage.AddHotel());
        }
    }
}
