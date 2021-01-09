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

namespace Challenge021
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Instantate variables

            string resultname = string.Format(" Driver - {0} ", textBoxName.Text);

            double ss = double.Parse(textBoxSS.Text);

            string resultSS = string.Format("Social Security Number # {0 : 000-00-0000} ", ss);

            double phone = double.Parse(textBoxPhone.Text);

            string resultPhone = string.Format(" Phone Number : {0 : (000)000-0000} ", phone);





            //Format Driver Info

            labelName.Content = resultname;

            labelSS.Content = resultSS; 

            labelPhone.Content = resultPhone;





            //Get Total Days

            int days = Convert.ToInt32((calendarLeft.SelectedDate.Value - calendarReturn.SelectedDate.Value).Days);


            labelDaysOut.Content = $"Days Out: {days}";

            //Get Total Miles

            int miles = Convert.ToInt32(textBoxEM) - Convert.ToInt32(textBoxSM);

            labelMiles.Content = $" Total Miles: {miles}";

            //Get Total Pay

            double pay = (checkBoxRef.IsChecked == true) ? miles * .37 : miles * .27;

            labelPayDue.Content = string.Format(" Pay Due: {0:c}", pay);

            //Get total vacation days

            int vc = days / 5;

            labelVCDays.Content = $"Vacation Earned: {vc} Days";








        }
    }
}
