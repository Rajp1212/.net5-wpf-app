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

namespace Proj2_Patel
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
        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            string type = "";
            string other = "";
            string name = tb1.Text;
            string mat = "";
            decimal cost = 0.00m;

            bt1.Content = "";
            tb1.Background = new SolidColorBrush(Colors.White);

            //Body Type
            if(rd1.IsChecked==true)
            {
                cost += 20000;
                type = "2 Door Sedan";
                bt1.Content = cost.ToString("C");
            }
            else if (rd2.IsChecked == true)
            {
                cost += 30000;
                type = "2 Door Sedan";
                bt1.Content = cost.ToString("C");
            }
            else if (rd3.IsChecked == true)
            {
                cost += 50000;
                type = "2 Door Sedan";
                bt1.Content = cost.ToString("C");
            }
            else if (rd4.IsChecked == true)
            {
                cost += 200000;
                type = "2 Door Sedan";
                bt1.Content = cost.ToString("C");
            }
            else
            {
                MessageBox.Show("Invalid Selection. Please select a body type to continue. Thank you!");
            }

            //Interior Section
            ComboBoxItem interior = (ComboBoxItem)cb1.SelectedItem;
            string select = interior.Tag.ToString();

            switch(select)
            {
                case "Standard":
                    break;

                case "Leather":
                    cost += 2000;
                    bt1.Content = cost.ToString("C");
                    break;
            }

            //Option Section
            if((op1.IsChecked==true)&&(op2.IsChecked==false)&&(op3.IsChecked==false))
            {
                cost += 1000;
                other = "Audio Package";
                bt1.Content = cost.ToString("C");
            }
            else if ((op2.IsChecked == true) && (op1.IsChecked == false) && (op3.IsChecked == false))
            {
                cost += 1000;
                other = "Xeon Lights";
                bt1.Content = cost.ToString("C");
            }
            else if ((op3.IsChecked == true) && (op1.IsChecked == false) && (op2.IsChecked == false))
            {
                cost += 1000;
                other = "Chrome Wheels";
                bt1.Content = cost.ToString("C");
            }
            else if ((op1.IsChecked == true) && (op2.IsChecked == true) && (op3.IsChecked == false))
            {
                cost += 2000;
                other = "Audio Package and Xeon Lights";
                bt1.Content = cost.ToString("C");
            }
            else if ((op1.IsChecked == true) && (op3.IsChecked == true) && (op2.IsChecked == false))
            {
                cost += 2000;
                other = "Audio Package and Chrome Wheels";
                bt1.Content = cost.ToString("C");
            }
            else if ((op2.IsChecked == true) && (op3.IsChecked == true) && (op1.IsChecked == false))
            {
                cost += 2000;
                other = "Neon Lights and Chrome Wheels";
                bt1.Content = cost.ToString("C");
            }
            else if ((op1.IsChecked == true) && (op2.IsChecked == true) && (op3.IsChecked == true))
            {
                cost += 3000;
                other = "Audio Package, Neon Lights and Chrome Wheels";
                bt1.Content = cost.ToString("C");
            }

            //Name Section
            if(string.IsNullOrEmpty(name))
            {
                tb1.Background = new SolidColorBrush(Colors.Red);
                MessageBox.Show("Please enter name to finalize your order");
            }

            //Mat Section
            if(rd5.IsChecked==true)
            {
                cost += 0;
                mat = "Standard";
                bt1.Content = cost.ToString("C");
            }
            else if(rd6.IsChecked==true)
            {
                cost += 200;
                mat = "Premium";
                bt1.Content = cost.ToString("C");
            }
            else
            {
                MessageBox.Show("Invalid Selection. Please select your mat type to continue. Thank you!");
            }

            //Summary Section
            if (!string.IsNullOrEmpty(type) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(mat))
            {
                _ = MessageBox.Show($"Thank you for your order {name}! You ordered a {type} with {select} interior {other} {mat} mats. Your order total is {cost:C}");
                    return;
            }
        }
    }
}
