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

namespace CompanyApp
{
    /// <summary>
    /// Логика взаимодействия для Property.xaml
    /// </summary>
    public partial class Property : Window
    {
        public Property()
        {
            InitializeComponent();
        }

        private void SaveProperty_Click(object sender, RoutedEventArgs e)
        {
            
                MainWindow main = this.Owner as MainWindow;
                if (main != null)
                {
                    try
                    {
                        double PropertyFontSize = Convert.ToDouble(CalendarWidth_TextBox.Text);
                        main.DateBirthdayIndividual_DateTimePicker.CalendarWidth = PropertyFontSize;
                    }
                    catch
                    {
                        main.StatusBar_TextBlock.Text = "Error";
                    }
                }
                
            
        }
    }
}
