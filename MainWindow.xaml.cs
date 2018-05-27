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

namespace binaryconversion
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

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            int convert = Convert.ToInt32(txtInput.Text);
            string binary = Convert.ToString(convert, 2);
            if(convert <= 0)
            {
                MessageBox.Show("Number entered cannot be less than zero.");
            }
            else if(convert >= 21)
            {
                MessageBox.Show("Number entered cannot be more than 20.");
            }
            else if(convert <= 20 && convert >= 1)
            {
            MessageBox.Show(binary);
            }
           
        }
    }
}
