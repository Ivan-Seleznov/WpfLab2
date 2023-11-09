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
using System.Windows.Shapes;
using WpfLab2.Lab3;

namespace WpfLab2
{
    /// <summary>
    /// Interaction logic for AbstractWindow.xaml
    /// </summary>
    public partial class AbstractWindow : Window
    {
        public AbstractWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(ArraySize.Text);
                if (n < 5)
                {
                    MessageBox.Show("Введено некоректні дані. Мінімальна кількість елементів масиву - 5");
                    return;
                }

                PrintedProduct[] printedProducts = new PrintedProduct[n];
                for (int i = 0; i < printedProducts.Length; i++) 
                {
                    var rand = new Random();
                    printedProducts[i] = new Magazine($"test {i + 1}", rand.Next(0,2000), rand.Next(0, 6000));

                    if ((i + 1) < printedProducts.Length)
                    {
                        printedProducts[i + 1] = new Newspaper($"test {i + 2}", rand.Next(0, 2000), rand.Next(0, 200), rand.Next(0, 6000));
                    }
                }

                ListBox.Items.Clear();
                foreach (var product in printedProducts) 
                {
                    ListBox.Items.Add(product.ToString() + " Total Price: " + product.CalculatePrice().ToString());
                }
                
                double totalCost = printedProducts.Sum(product => product.CalculatePrice());
                double averageCost = totalCost / printedProducts.Length;

                AverageCost.Content = averageCost.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введено некоректні дані.\n" + ex.Message);
            }
        }

    }
}
