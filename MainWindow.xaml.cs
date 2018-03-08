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

namespace U1_03_Dylan_sCompParts
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
            btnMother.Visibility = Visibility.Collapsed;
            btnCPU.Visibility = Visibility.Visible;
            imgCPU.Visibility = Visibility.Visible;
            btnCASE.Visibility = Visibility.Collapsed;
        }

        private void btnCPU_Click(object sender, RoutedEventArgs e)
        {
            btnMother.Visibility = Visibility.Collapsed;
            btnCPU.Visibility = Visibility.Collapsed;
            imgCPU.Visibility = Visibility.Collapsed;
            btnCASE.Visibility = Visibility.Visible;
            imgCASE.Visibility = Visibility.Visible;
        }

        private void btnCASE_Click(object sender, RoutedEventArgs e)
        {
            btnMother.Visibility = Visibility.Collapsed;
            btnCPU.Visibility = Visibility.Collapsed;
            imgCPU.Visibility = Visibility.Collapsed;
            btnCASE.Visibility = Visibility.Collapsed;
            imgCASE.Visibility = Visibility.Collapsed;
            btnPWRSUPPLY.Visibility = Visibility.Visible;
            imgPWRSUPPLY.Visibility = Visibility.Visible;
        }

        private void btnPWRSUPPLY_Click(object sender, RoutedEventArgs e)
        {
            btnMother.Visibility = Visibility.Collapsed;
            btnCPU.Visibility = Visibility.Collapsed;
            imgCPU.Visibility = Visibility.Collapsed;
            btnCASE.Visibility = Visibility.Collapsed;
            imgCASE.Visibility = Visibility.Collapsed;
            btnPWRSUPPLY.Visibility = Visibility.Collapsed;
            imgPWRSUPPLY.Visibility = Visibility.Collapsed;
            btnMEMORY.Visibility = Visibility.Visible;
            imgMEMORY.Visibility = Visibility.Visible;
        }

        private void btnMEMORY_Click(object sender, RoutedEventArgs e)
        {
            btnMother.Visibility = Visibility.Collapsed;
            btnCPU.Visibility = Visibility.Collapsed;
            imgCPU.Visibility = Visibility.Collapsed;
            btnCASE.Visibility = Visibility.Collapsed;
            imgCASE.Visibility = Visibility.Collapsed;
            btnPWRSUPPLY.Visibility = Visibility.Collapsed;
            imgPWRSUPPLY.Visibility = Visibility.Collapsed;
            btnMEMORY.Visibility = Visibility.Collapsed;
            imgMEMORY.Visibility = Visibility.Collapsed;
            btnSTORAGE.Visibility = Visibility.Visible;
            imgSTORAGE.Visibility = Visibility.Visible;

        }
    }
    }      

