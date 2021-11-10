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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resEuro = rateEuro * sumEuro;
            resSum1.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateHryvnia = Convert.ToDouble(rate2.Text);
            double sumHryvnia = Convert.ToDouble(sum2.Text);
            double resHryvnia = rateHryvnia * sumHryvnia;
            resSum2.Text = resHryvnia.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDramas = Convert.ToDouble(rate3.Text);
            double sumDramas = Convert.ToDouble(sum3.Text);
            double resDramas = rateDramas * sumDramas;
            resSum3.Text = resDramas.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double inches = Convert.ToDouble(inputInches.Text);
            double meters = 0.0254 * inches;
            inchesToMeters.Text = meters.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double feet = Convert.ToDouble(inputFeet.Text);
            double meters = 0.3048 * feet;
            feetToMeters.Text = meters.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double miles = Convert.ToDouble(inputMiles.Text);
            double meters = 1609.34 * miles;
            milesToMeters.Text = meters.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double versts = Convert.ToDouble(inputVersts.Text);
            double meters = 1066.8 * versts;
            verstsToMeters.Text = meters.ToString();
        }
    }
}
