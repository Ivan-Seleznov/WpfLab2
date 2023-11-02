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

namespace WpfLab2
{
    /// <summary>
    /// Interaction logic for InheritanceWindow.xaml
    /// </summary>
    public partial class InheritanceWindow : Window
    {
        public InheritanceWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int phoneFuncNumber = Convert.ToInt32(PhoneFuncNumberTextBox.Text);

                Phone phone = new Phone(phoneFuncNumber);
                PhonePrice.Content = phone.CalculateCost() + "$";


                int mobilePhoneFuncNumber = Convert.ToInt32(MobilePhoneFuncNumberTextBox.Text);
                if (String.IsNullOrEmpty(MobilePhoneModelTextBox.Text))
                {
                    throw new Exception("MobilePhoneModelTextBox is empty");
                }

                Phone mobilePhone = new MobilePhone(mobilePhoneFuncNumber, MobilePhoneModelTextBox.Text);
                MobilePhonePrice.Content = mobilePhone.CalculateCost() + "";
            }
            catch
            {
                MessageBox.Show("Введені некоректні дані");
            }
        }
    }
}
