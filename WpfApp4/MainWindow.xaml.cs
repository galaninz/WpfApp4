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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_ClickS(object sender, RoutedEventArgs e)
        {
            double rateDollar=Convert.ToDouble(rateS.Text);
            double sumDollar=Convert.ToDouble(sumS.Text);
            double resDollar = rateDollar * sumDollar;
            resSumS.Text= resDollar.ToString();
        }

        private void Button_ClickE(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateE.Text);
            double sumEuro = Convert.ToDouble(sumE.Text);
            double resDouble = rateEuro * sumEuro;
            resSumE.Text = resDouble.ToString();
        }
        private void Button_ClickG(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rateG.Text);
            double sumGrivna = Convert.ToDouble(sumG.Text);
            double resGrivna = rateGrivna * sumGrivna;
            resSumG.Text = resGrivna.ToString();
        }
        private void Button_ClickD(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rateD.Text);
            double sumDram = Convert.ToDouble(sumD.Text);
            double resDram = rateDram * sumDram;
            resSumD.Text = resDram.ToString();
        }
        private void Button_ClickI(object sender, RoutedEventArgs e)
        {
            double rateInch = Convert.ToDouble(rateI.Text);
            double conInch = rateInch * 0.0254;
            conI.Text = conInch.ToString();
        }
        private void Button_ClickF(object sender, RoutedEventArgs e)
        {
            double rateFeet = Convert.ToDouble(rateF.Text);
            double conFeet = rateFeet * 0.3048;
            conF.Text = conFeet.ToString();
        }
        private void Button_ClickM(object sender, RoutedEventArgs e)
        {
            double rateMile = Convert.ToDouble(rateM.Text);
            double conMile = rateMile * 1609.34;
            conM.Text = conMile.ToString();
        }
        private void Button_ClickV(object sender, RoutedEventArgs e)
        {
            double rateVerst = Convert.ToDouble(rateV.Text);
            double conVerst = rateVerst * 0.000937383;
            conV.Text = conVerst.ToString();
        }

    }
}
