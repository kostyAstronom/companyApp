using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Threading;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Xceed.Wpf.Toolkit;

namespace CompanyApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

            Thread.Sleep(1000);

            // Set background image
            BackgroundImg_Image.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Image\\Logo.jpg"));
        }

        private void CloseAllGrid()
        {
            BackgroundForm.Visibility = Visibility.Collapsed;
            CompanyForm.Visibility = Visibility.Collapsed;
            ClientForm.Visibility = Visibility.Collapsed;
            PolicyForm.Visibility = Visibility.Collapsed;
            CategoryForm.Visibility = Visibility.Collapsed;
            AccidentForm.Visibility = Visibility.Collapsed;
            ClientAccidentForm.Visibility = Visibility.Collapsed;
            ClientInfoForm.Visibility = Visibility.Collapsed;
        }

        ///////////////////////////////////////
        ////            GRAPHICS           ////
        ///////////////////////////////////////

        // Brush
        private Brush BlackSolidBrush = new SolidColorBrush(Colors.Black);
        private Brush RedSolidBrush = new SolidColorBrush(Colors.Red);
        private Brush SilverSolidBrush = new SolidColorBrush(Colors.Silver);

        ///////////////////////////////////////
        ////           INDIVIDUAL          ////
        ///////////////////////////////////////

        // For check validation enter value
        private bool CheckValidationFirstnameIndividual = false;
        private bool CheckValidationLastnameIndividual = false;
        private bool CheckValidationThirdnameIndividual = false;
        private bool CheckValidationDataBirthdayIndividual = false;
        private bool CheckValidationSexIndividual = false;
        private bool CheckValidationAddressIndividual = false;
        private bool CheckValidationPhoneIndividual = false;
        private bool CheckValidationDriveExperienceIndividual = false;
        private bool CheckValidationSourceImgIndividual = false;

        // Call IndividualForm
        private void IndividualForm_Click(object sender, RoutedEventArgs e)
        {
            CloseAllGrid();
            ClientForm.Visibility = Visibility.Visible;

            // Clean old value
            ClearIndividual_Click(null, null);

            // Set defaul 
            DataBirthdayIndividual_DateTimePicker.Maximum = DateTime.Today;
            DataBirthdayIndividual_DateTimePicker.Minimum = new DateTime(DateTime.Today.Year - 100, DateTime.Today.Month, DateTime.Today.Day);

            // Set focus
            FirstnameIndividual_TextBox.Focus();
        }

        // Got and lost focus FirstnameIndividual
        private void FirstnameIndividual_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = BlackSolidBrush;
            ((TextBox)sender).Text = "";

            // Delete got focus handler
            ((TextBox)sender).GotFocus -= FirstnameIndividual_GotFocus;
        }

        private void FirstnameIndividual_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                // Set default value
                ((TextBox)sender).BorderBrush = SilverSolidBrush;
                ((TextBox)sender).Foreground = SilverSolidBrush;
                ((TextBox)sender).Text = "First Name";

                // Add got focus hendler
                ((TextBox)sender).GotFocus += FirstnameIndividual_GotFocus;
            }
        }

        private void FirstnameIndividual_TextChanged(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "" || ((TextBox)sender).Text == "First Name")
            {
                CheckValidationFirstnameIndividual = false;
            }
            else
            {
                // For check validation enter value
                bool ResultValidation = true;
                for (int i = 0; i < ((TextBox)sender).Text.Length; ++i)
                {
                    if (!(char.IsLetter(((TextBox)sender).Text[i]) || ((TextBox)sender).Text[i] == '-'))
                    {
                        ResultValidation = false;
                    }
                }
                // Processing of the results validation
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = SilverSolidBrush;
                    CheckValidationFirstnameIndividual = true;
                }
                else
                {
                    ((TextBox)sender).BorderBrush = RedSolidBrush;
                    CheckValidationFirstnameIndividual = false;
                }
            }
        }

        // Got and lost focus LastnameIndividual
        private void LastnameIndividual_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = BlackSolidBrush;
            ((TextBox)sender).Text = "";

            // Delete got focus handler
            ((TextBox)sender).GotFocus -= LastnameIndividual_GotFocus;
        }

        private void LastnameIndividual_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                // Set default value
                ((TextBox)sender).BorderBrush = SilverSolidBrush;
                ((TextBox)sender).Foreground = SilverSolidBrush;
                ((TextBox)sender).Text = "Last Name";

                // Add got focus hendler
                ((TextBox)sender).GotFocus += LastnameIndividual_GotFocus;
            }
        }

        private void LastnameIndividual_TextChanged(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "" || ((TextBox)sender).Text == "Last Name")
            {
                CheckValidationLastnameIndividual = false;
            }
            else
            {
                // For check validation enter value
                bool ResultValidation = true;
                for (int i = 0; i < ((TextBox)sender).Text.Length; ++i)
                {
                    if (!(char.IsLetter(((TextBox)sender).Text[i]) || ((TextBox)sender).Text[i] == '-'))
                    {
                        ResultValidation = false;
                    }
                }
                // Processing of the results validation
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = SilverSolidBrush;
                    CheckValidationLastnameIndividual = true;
                }
                else
                {
                    ((TextBox)sender).BorderBrush = RedSolidBrush;
                    CheckValidationLastnameIndividual = false;
                }
            }
        }

        // Got and lost focus ThirdameIndividual
        private void ThirdnameIndividual_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = BlackSolidBrush;
            ((TextBox)sender).Text = "";

            // Delete got focus hendler
            ((TextBox)sender).GotFocus -= ThirdnameIndividual_GotFocus;
        }

        private void ThirdnameIndividual_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                // Set default value
                ((TextBox)sender).BorderBrush = SilverSolidBrush;
                ((TextBox)sender).Foreground = SilverSolidBrush;
                ((TextBox)sender).Text = "Third Name";

                // Delete got focus hendler
                ((TextBox)sender).GotFocus += ThirdnameIndividual_GotFocus;
            }
        }

        private void TrirdnameIndividual_TextChanged(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "" || ((TextBox)sender).Text == "Third Name")
            {
                CheckValidationThirdnameIndividual = false;
            }
            else
            {
                // For check validation enter value
                bool ResultValidation = true;
                for (int i = 0; i < ((TextBox)sender).Text.Length; ++i)
                {
                    if (!(char.IsLetter(((TextBox)sender).Text[i]) || ((TextBox)sender).Text[i] == '-'))
                    {
                        ResultValidation = false;
                    }
                }
                // Processing of the results validation
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = SilverSolidBrush;
                    CheckValidationThirdnameIndividual = true;
                }
                else
                {
                    ((TextBox)sender).BorderBrush = RedSolidBrush;
                    CheckValidationThirdnameIndividual = false;
                }
            }
        }

        // Got and lost focus DataBirthdayIndividual
        private void DataBirthdayIndividual_GotFocus(object sender, RoutedEventArgs e)
        {
            ((DateTimePicker)sender).Foreground = BlackSolidBrush;
            ((DateTimePicker)sender).Text = "";

            // Delete got focus hendler
            ((DateTimePicker)sender).GotFocus -= DataBirthdayIndividual_GotFocus;
        }

        private void DataBirthdayIndividual_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((DateTimePicker)sender).Text == "")
            {
                // Set default value
                ((DateTimePicker)sender).BorderBrush = SilverSolidBrush;
                ((DateTimePicker)sender).Foreground = SilverSolidBrush;

                // Delete got focus hendler
                ((DateTimePicker)sender).GotFocus += DataBirthdayIndividual_GotFocus;
            }
        }

        private void DataBirthdayIndividual_SelectedDataContextChanged(object sender, RoutedEventArgs e)
        {
            if (((DateTimePicker)sender).Text == "")
            {
                CheckValidationDataBirthdayIndividual = false;
            }
            else
            {
                // For check validation enter value
                bool ResultValidation = true;
                // Processing of the results validation
                if (ResultValidation)
                {
                    ((DateTimePicker)sender).BorderBrush = SilverSolidBrush;
                    CheckValidationDataBirthdayIndividual = true;
                }
                else
                {
                    ((DateTimePicker)sender).BorderBrush = RedSolidBrush;
                    CheckValidationDataBirthdayIndividual = false;
                }
            }
        }

        // Lost focus SexIndividual
        private void SexIndividual_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((ComboBox)sender).SelectedItem == null)
            {
                // Check validation enter value
                CheckValidationSexIndividual = false;
            }
            else
            {
                ((ComboBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);

                // Check validation enter value
                CheckValidationSexIndividual = true;
            }
        }

        // Got and lost focus AddressIndividual
        private void AddressIndividual_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= AddressIndividual_GotFocus;
        }

        private void AddressIndividual_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                // Return default value     
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Address";
                ((TextBox)sender).GotFocus += AddressIndividual_GotFocus;
                CheckValidationAddressIndividual = false;
            }
        }

        private void AddressIndividual_TextChanged(object sender, RoutedEventArgs e)
        {
            // Check validation enter value
            bool ResultValidation = true;
            if (((TextBox)sender).Text == "")
            {
                CheckValidationAddressIndividual = false;
            }
            else if (((TextBox)sender).Text == "Address")
            {
                CheckValidationAddressIndividual = false;
            }
            else
            {
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                    CheckValidationAddressIndividual = true;
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                    CheckValidationAddressIndividual = false;
                }
            }
        }

        // Got and lost focus PhoneIndividual
        private void PhoneIndividual_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= PhoneIndividual_GotFocus;
        }

        private void PhoneIndividual_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "+375 (__) ___-__-__")
            {
                // Return defaut value
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "";
                ((TextBox)sender).GotFocus += PhoneIndividual_GotFocus;
                CheckValidationPhoneIndividual = false;
            }
        }

        private void PhoneIndividual_TextChanged(object sender, RoutedEventArgs e)
        {
            // Check validation enter value
            bool ResultValidation = true;
            if (((TextBox)sender).Text == "+375 (__) ___-__-__")
            {
                CheckValidationPhoneIndividual = false;
            }
            else
            {
                if (!((MaskedTextBox)sender).IsMaskFull) ResultValidation = false;
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                    CheckValidationPhoneIndividual = true;
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                    CheckValidationPhoneIndividual = false;
                }
            }
        }

        // Got and lost focus DriveExperienceIndividual
        private void DriveExperienceIndividual_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= DriveExperienceIndividual_GotFocus;
        }

        private void DriveExperienceIndividual_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Drive experience";
                ((TextBox)sender).GotFocus += DriveExperienceIndividual_GotFocus;
                CheckValidationDriveExperienceIndividual = false;
            }
        }

        private void DriveExperienceIndividual_TextChanged(object sender, RoutedEventArgs e)
        {
            // Check validation enter value
            bool ResultValidation = true;
            if (((TextBox)sender).Text == "")
            {
                CheckValidationDriveExperienceIndividual = false;
            }
            else if (((TextBox)sender).Text == "Drive experience")
            {
                CheckValidationDriveExperienceIndividual = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(((TextBox)sender).Text);
                }
                catch
                {
                    ResultValidation = false;
                }
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                    CheckValidationDriveExperienceIndividual = true;
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                    CheckValidationDriveExperienceIndividual = false;
                }
            }
        }

        // Got and lost focus SourceImgIndividual
        private void SourceImgIndividual_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= SourceImgIndividual_GotFocus;
        }

        private void SourceImgIndividual_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Source";
                ((TextBox)sender).GotFocus += SourceImgIndividual_GotFocus;
                CheckValidationSourceImgIndividual = false;
            }
        }

        private void SourceImgIndividual_TextChanged(object sender, RoutedEventArgs e)
        {
            // Check validation enter value
            bool ResultValidation = true;
            if (((TextBox)sender).Text == "")
            {
                CheckValidationSourceImgIndividual = false;
            }
            else if (((TextBox)sender).Text == "Source")
            {
                CheckValidationSourceImgIndividual = false;
            }
            else
            {
                try
                {
                    ImgIndividual_Image.Source = new BitmapImage(new Uri(((TextBox)sender).Text));
                }
                catch
                {
                    ResultValidation = false;
                }
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                    CheckValidationSourceImgIndividual = true;
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                    CheckValidationSourceImgIndividual = false;
                }
            }
        }

        // OpenFileDialog
        private void OpenFileDialog_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension
            dlg.DefaultExt = ".jpg";
            dlg.Filter = "JPG file (.jpg)|*.jpg";

            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox
            if (result == true)
            {
                // Set image
                ImgIndividual_Image.Source = new BitmapImage(new Uri(dlg.FileName));
                
                // GotFocus in SourceImgIndividual_TextBox
                SourceImgIndividual_TextBox.Focus();

                // Set source
                SourceImgIndividual_TextBox.Foreground = new SolidColorBrush(Colors.Black);
                SourceImgIndividual_TextBox.FontStyle = FontStyles.Normal;
                SourceImgIndividual_TextBox.Text = dlg.FileName;
            }
        }
        
        // Save our value
        private void SaveIndividual_Click(object sender, RoutedEventArgs e)
        {
            if (CheckValidationFirstnameIndividual && 
                CheckValidationLastnameIndividual && 
                CheckValidationThirdnameIndividual &&
                CheckValidationDataBirthdayIndividual && 
                CheckValidationSexIndividual &&
                CheckValidationAddressIndividual && 
                CheckValidationPhoneIndividual &&
                CheckValidationDriveExperienceIndividual && 
                CheckValidationSourceImgIndividual)
            {
                //
                // Code
                //
                System.Windows.MessageBox.Show(FirstnameIndividual_TextBox.Text + " " + LastnameIndividual_TextBox.Text + " " + ThirdnameIndividual_TextBox.Text + "\n" + SexIndividual_ComboBox.Text + ", " + "\n" + AddressIndividual_TextBox.Text + "\n" + PhoneIndividual_TextBox.Text + "\n" + DriveExperienceIndividual_TextBox.Text, "Add New CLient", MessageBoxButton.OK, MessageBoxImage.Information);

                CloseAllGrid();
                BackgroundForm.Visibility = Visibility.Visible;
            }
            else
            {
                if (!CheckValidationFirstnameIndividual)
                {
                    FirstnameIndividual_TextBox.Focus();
                    FirstnameIndividual_TextBox.BorderBrush = new SolidColorBrush(Colors.Red);
                    FirstnameIndividual_TextBox.Background = new SolidColorBrush(Colors.LightPink);
                }
                else if (!CheckValidationLastnameIndividual)
                {
                    LastnameIndividual_TextBox.Focus();
                    LastnameIndividual_TextBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else if (!CheckValidationThirdnameIndividual)
                {
                    ThirdnameIndividual_TextBox.Focus();
                    ThirdnameIndividual_TextBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else if (!CheckValidationDataBirthdayIndividual)
                {
                    DataBirthdayIndividual_DateTimePicker.Focus();
                    DataBirthdayIndividual_DateTimePicker.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else if (!CheckValidationSexIndividual)
                {
                    SexIndividual_ComboBox.Focus();
                    SexIndividual_ComboBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else if (!CheckValidationAddressIndividual)
                {
                    AddressIndividual_TextBox.Focus();
                    AddressIndividual_TextBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else if (!CheckValidationPhoneIndividual)
                {
                    PhoneIndividual_TextBox.Focus();
                    PhoneIndividual_TextBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else if (!CheckValidationDriveExperienceIndividual)
                {
                    DriveExperienceIndividual_TextBox.Focus();
                    DriveExperienceIndividual_TextBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else if (!CheckValidationSourceImgIndividual)
                {
                    SourceImgIndividual_TextBox.Focus();
                    SourceImgIndividual_TextBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }


            }
        }

        // Set all value in default
        private void ClearIndividual_Click(object sender, RoutedEventArgs e)
        {
            // Set default firstname
            FirstnameIndividual_TextBox.Text = "";
            FirstnameIndividual_LostFocus(FirstnameIndividual_TextBox, null);
            // Set default lastname
            LastnameIndividual_TextBox.Text = "";
            LastnameIndividual_LostFocus(LastnameIndividual_TextBox, null);
            // Set default thirdname
            ThirdnameIndividual_TextBox.Text = "";
            ThirdnameIndividual_LostFocus(ThirdnameIndividual_TextBox, null);
            // Set default data birthday
            DataBirthdayIndividual_DateTimePicker.Text = "";
            DataBirthdayIndividual_LostFocus(DataBirthdayIndividual_DateTimePicker, null);
            // Set default sex
            SexIndividual_ComboBox.Text = "";
            // Set default address
            AddressIndividual_TextBox.Text = "";
            AddressIndividual_LostFocus(AddressIndividual_TextBox, null);
            // Set default phone
            PhoneIndividual_TextBox.Text = "";
            PhoneIndividual_LostFocus(PhoneIndividual_TextBox, null);
            // Set default drive expirience
            DriveExperienceIndividual_TextBox.Text = "";
            DriveExperienceIndividual_LostFocus(DriveExperienceIndividual_TextBox, null);
            // Set default source
            SourceImgIndividual_TextBox.Text = "";
            SourceImgIndividual_LostFocus(SourceImgIndividual_TextBox, null);
            // Set default image
            ImgIndividual_Image.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Image\\DefaultImgIndividual.png"));

            

            // Set default check value
            CheckValidationFirstnameIndividual = false;
            CheckValidationLastnameIndividual = false;
            CheckValidationThirdnameIndividual = false;
            CheckValidationDataBirthdayIndividual = false;
            CheckValidationSexIndividual = false;
            CheckValidationAddressIndividual = false;
            CheckValidationPhoneIndividual = false;
            CheckValidationDriveExperienceIndividual = false;
            CheckValidationSourceImgIndividual = false;
    }

        // Cancel our value
        private void CancelIndividual_Click(object sender, RoutedEventArgs e)
        {

            ClearIndividual_Click(null, null);
            // Exit
            CloseAllGrid();
            BackgroundForm.Visibility = Visibility.Visible;
        }

        ///////////////////////////////////////
        ////            COMPANY            ////
        ///////////////////////////////////////

        private void CompanyForm_Click(object sender, RoutedEventArgs e)
        {
            CloseAllGrid();
            CompanyForm.Visibility = Visibility.Visible;

            // Clean old value
            ClearCompany_Click(null, null);
        }

        // Got and lost focus NameCompany
        private void NameCompany_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= NameCompany_GotFocus;
        }

        private void NameCompany_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Company name";
                ((TextBox)sender).GotFocus += NameCompany_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                //
                // Code check validation enter value
                //
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Got and lost focus UNNCompany
        private void UNNCompany_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= UNNCompany_GotFocus;
        }

        private void UNNCompany_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Company UNN";
                ((TextBox)sender).GotFocus += UNNCompany_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                try
                {
                    Convert.ToInt32(((TextBox)sender).Text);
                }
                catch
                {
                    ResultValidation = false;
                }
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Got and lost focus BossFirstname
        private void BossFirstname_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= BossFirstname_GotFocus;
        }

        private void BossFirstname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Boss firstname";
                ((TextBox)sender).GotFocus += BossFirstname_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                for (int i = 0; i < ((TextBox)sender).Text.Length; ++i)
                {
                    if (!char.IsLetter(((TextBox)sender).Text[i]))
                    {
                        ResultValidation = false;
                    }
                }
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Got and lost focus BossLastname
        private void BossLastname_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= BossLastname_GotFocus;
        }

        private void BossLastname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Boss lastname";
                ((TextBox)sender).GotFocus += BossLastname_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                for (int i = 0; i < ((TextBox)sender).Text.Length; ++i)
                {
                    if (!char.IsLetter(((TextBox)sender).Text[i]))
                    {
                        ResultValidation = false;
                    }
                }
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Got and lost focus BossThirdtname
        private void BossThirdname_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= BossThirdname_GotFocus;
        }

        private void BossThirdname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Boss thirdname";
                ((TextBox)sender).GotFocus += BossThirdname_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                for (int i = 0; i < ((TextBox)sender).Text.Length; ++i)
                {
                    if (!char.IsLetter(((TextBox)sender).Text[i]))
                    {
                        ResultValidation = false;
                    }
                }
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Got and lost focus AccountantFirstname
        private void AccountantFirstname_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= AccountantFirstname_GotFocus;
        }

        private void AccountantFirstname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Accountant firstname";
                ((TextBox)sender).GotFocus += AccountantFirstname_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                for (int i = 0; i < ((TextBox)sender).Text.Length; ++i)
                {
                    if (!char.IsLetter(((TextBox)sender).Text[i]))
                    {
                        ResultValidation = false;
                    }
                }
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Got and lost focus AccountantLastname
        private void AccountantLastname_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= AccountantLastname_GotFocus;
        }

        private void AccountantLastname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Accountant lastname";
                ((TextBox)sender).GotFocus += AccountantLastname_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                for (int i = 0; i < ((TextBox)sender).Text.Length; ++i)
                {
                    if (!char.IsLetter(((TextBox)sender).Text[i]))
                    {
                        ResultValidation = false;
                    }
                }
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Got and lost focus AccountantThirdtname
        private void AccountantThirdname_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= AccountantThirdname_GotFocus;
        }

        private void AccountantThirdname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Accountant thirdname";
                ((TextBox)sender).GotFocus += AccountantThirdname_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                for (int i = 0; i < ((TextBox)sender).Text.Length; ++i)
                {
                    if (!char.IsLetter(((TextBox)sender).Text[i]))
                    {
                        ResultValidation = false;
                    }
                }
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Got and lost focus AddressCompany
        private void AddressCompany_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= AddressCompany_GotFocus;
        }

        private void AddressCompany_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Address";
                ((TextBox)sender).GotFocus += AddressCompany_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                //
                // Code check validation enter value
                //
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Got and lost focus PhoneCompany
        private void PhoneCompany_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= PhoneCompany_GotFocus;
        }

        private void PhoneCompany_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Phone";
                ((TextBox)sender).GotFocus += PhoneCompany_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                try
                {
                    Convert.ToInt32(((TextBox)sender).Text);
                }
                catch
                {
                    ResultValidation = false;
                }
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Save our value
        private void SaveCompany_Click(object sender, RoutedEventArgs e)
        {
            //
            // Code
            //
            CloseAllGrid();
            BackgroundForm.Visibility = Visibility.Visible;
        }

        // Set all value in default
        private void ClearCompany_Click(object sender, RoutedEventArgs e)
        {
            // Set default company name
            NameCompany_TextBox.Text = "";
            NameCompany_LostFocus(NameCompany_TextBox, null);
            // Set default company unn
            UNNCompany_TextBox.Text = "";
            UNNCompany_LostFocus(UNNCompany_TextBox, null);
            // Set default firstname boss
            BossFirstname_TextBox.Text = "";
            BossFirstname_LostFocus(BossFirstname_TextBox, null);
            // Set default lastname boss
            BossLastname_TextBox.Text = "";
            BossLastname_LostFocus(BossLastname_TextBox, null);
            // Set default thirdname boss
            BossThirdname_TextBox.Text = "";
            BossThirdname_LostFocus(BossThirdname_TextBox, null);
            // Set default firstname accountant
            AccountantFirstname_TextBox.Text = "";
            AccountantFirstname_LostFocus(AccountantFirstname_TextBox, null);
            // Set default lastname accountant
            AccountantLastname_TextBox.Text = "";
            AccountantLastname_LostFocus(AccountantLastname_TextBox, null);
            // Set default thirdname accountant
            AccountantThirdname_TextBox.Text = "";
            AccountantThirdname_LostFocus(AccountantThirdname_TextBox, null);
            // Set default address
            AddressCompany_TextBox.Text = "";
            AddressCompany_LostFocus(AddressCompany_TextBox, null);
            // Set default phone
            PhoneCompany_TextBox.Text = "";
            PhoneCompany_LostFocus(PhoneCompany_TextBox, null);
        }

        // Cancel our value
        private void CancelCompany_Click(object sender, RoutedEventArgs e)
        {
            ClearCompany_Click(null, null);
            // Exit
            CloseAllGrid();
            BackgroundForm.Visibility = Visibility.Visible;
        }

        ///////////////////////////////////////
        ////            POLICY             ////
        ///////////////////////////////////////

        private void PolicyForm_Click(object sender, RoutedEventArgs e)
        {
            CloseAllGrid();
            PolicyForm.Visibility = Visibility.Visible;

            // Clean old value
            ClearPolicy_Click(null, null);
        }

        // Got and lost focus id client
        private void ClientPolicy_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= ClientPolicy_GotFocus;
        }

        private void ClientPolicy_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Client ID";
                ((TextBox)sender).GotFocus += ClientPolicy_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                try
                {
                    Convert.ToInt32(((TextBox)sender).Text);
                }
                catch
                {
                    ResultValidation = false;
                }
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Got and lost focus summ policy
        private void SumPolicy_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= SumPolicy_GotFocus;
        }

        private void SumPolicy_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Policy sum";
                ((TextBox)sender).GotFocus += SumPolicy_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                try
                {
                    Convert.ToInt32(((TextBox)sender).Text);
                }
                catch
                {
                    ResultValidation = false;
                }
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Save our value
        private void SavePolicy_Click(object sender, RoutedEventArgs e)
        {
            //
            // Code
            //
            CloseAllGrid();
            BackgroundForm.Visibility = Visibility.Visible;
        }

        // Set all value in default
        private void ClearPolicy_Click(object sender, RoutedEventArgs e)
        {
            // Set default client
            ClientPolicy_TextBox.Text = "";
            ClientPolicy_LostFocus(ClientPolicy_TextBox, null);
            // Set default category
            CategoryPolicy_ComboBox.Text = "";
            // Set default data start
            DataStartPolicy_DatePicker.Text = "";
            // Set default data finish
            DataFinishPolicy_DatePicker.Text = "";
            // Set default lastname boss
            SumPolicy_TextBox.Text = "";
            SumPolicy_LostFocus(SumPolicy_TextBox, null);
            // Set default thirdname boss
            PricePolicy_TextBox.Text = "Policy price";
        }

        // Cancel our value
        private void CancelPolicy_Click(object sender, RoutedEventArgs e)
        {
            ClearPolicy_Click(null, null);
            // Exit
            CloseAllGrid();
            BackgroundForm.Visibility = Visibility.Visible;
        }

        ///////////////////////////////////////
        ////           CATEGORY           /////
        ///////////////////////////////////////

        private void CategoryForm_Click(object sender, RoutedEventArgs e)
        {
            CloseAllGrid();
            CategoryForm.Visibility = Visibility.Visible;

            // Clean old value
            ClearCategory_Click(null, null);
        }

        // Got and lost focus category name
        private void NameCategory_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= NameCategory_GotFocus;
        }

        private void NameCategory_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Category name";
                ((TextBox)sender).GotFocus += NameCategory_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                //
                // Code cherk validation enter value
                //
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Got and lost focus max sum
        private void MaxSumCategory_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= MaxSumCategory_GotFocus;
        }

        private void MaxSumCategory_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "The maximum sum";
                ((TextBox)sender).GotFocus += MaxSumCategory_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                try
                {
                    Convert.ToInt32(((TextBox)sender).Text);
                }
                catch
                {
                    ResultValidation = false;
                }
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Got and lost focus max days
        private void MaxCountDaysCategory_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= MaxCountDaysCategory_GotFocus;
        }

        private void MaxCountDaysCategory_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "The maximum counts of days";
                ((TextBox)sender).GotFocus += MaxCountDaysCategory_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                try
                {
                    Convert.ToInt32(((TextBox)sender).Text);
                }
                catch
                {
                    ResultValidation = false;
                }
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Save our value
        private void SaveCategory_Click(object sender, RoutedEventArgs e)
        {
            //
            // Code
            //
            CloseAllGrid();
            BackgroundForm.Visibility = Visibility.Visible;
        }

        // Set all value in default
        private void ClearCategory_Click(object sender, RoutedEventArgs e)
        {
            // Set default name
            NameCategory_TextBox.Text = "";
            NameCategory_LostFocus(NameCategory_TextBox, null);
            // Set default data start
            AccidentCategory_ComboBox.Text = "";
            // Set default max sum
            MaxSumCategory_TextBox.Text = "";
            MaxSumCategory_LostFocus(MaxSumCategory_TextBox, null);
            // Set default max days
            MaxCountDaysCategory_TextBox.Text = "";
            MaxCountDaysCategory_LostFocus(MaxCountDaysCategory_TextBox, null);
        }

        // Cancel our value
        private void CancelCategory_Click(object sender, RoutedEventArgs e)
        {
            ClearCategory_Click(null, null);
            // Exit
            CloseAllGrid();
            BackgroundForm.Visibility = Visibility.Visible;
        }

        ///////////////////////////////////////
        ////           ACCIDENT            ////
        ///////////////////////////////////////

        private void AccidentForm_Click(object sender, RoutedEventArgs e)
        {
            CloseAllGrid();
            AccidentForm.Visibility = Visibility.Visible;

            // Clean old value
            ClearAccident_Click(null, null);
        }

        // Got and lost focus name accident
        private void NameAccident_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= NameAccident_GotFocus;
        }

        private void NameAccident_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Accident name";
                ((TextBox)sender).GotFocus += NameAccident_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                //
                // Code check validation enter value
                //
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Got and lost focus percent accident
        private void PercentAccident_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= PercentAccident_GotFocus;
        }

        private void PercentAccident_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Percent";
                ((TextBox)sender).GotFocus += PercentAccident_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                try
                {
                    Convert.ToInt32(((TextBox)sender).Text);
                }
                catch
                {
                    ResultValidation = false;
                }
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Save our value
        private void SaveAccident_Click(object sender, RoutedEventArgs e)
        {
            //
            // Code
            //
            CloseAllGrid();
            BackgroundForm.Visibility = Visibility.Visible;
        }

        // Set all value in default
        private void ClearAccident_Click(object sender, RoutedEventArgs e)
        {
           // Set default name accident
            NameAccident_TextBox.Text = "";
            NameAccident_LostFocus(NameAccident_TextBox, null);
            // Set default percent
            PercentAccident_TextBox.Text = "";
            PercentAccident_LostFocus(PercentAccident_TextBox, null);
        }

        // Cancel our value
        private void CancelAccident_Click(object sender, RoutedEventArgs e)
        {
            ClearAccident_Click(null, null);
            // Exit
            CloseAllGrid();
            BackgroundForm.Visibility = Visibility.Visible;
        }

        ///////////////////////////////////////
        ////        CLIENT ACCIDENT        ////
        ///////////////////////////////////////

        private void ClientAccidentForm_Click(object sender, RoutedEventArgs e)
        {
            CloseAllGrid();
            ClientAccidentForm.Visibility = Visibility.Visible;

            // Clean old value
            ClearClientAccident_Click(null, null);
        }

        // Got and lost focus id client
        private void ClientClientAccident_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= ClientClientAccident_GotFocus;
        }

        private void ClientClientAccident_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Client ID";
                ((TextBox)sender).GotFocus += ClientClientAccident_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                try
                {
                    Convert.ToInt32(((TextBox)sender).Text);
                }
                catch
                {
                    ResultValidation = false;
                }
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Save our value
        private void SaveClientAccident_Click(object sender, RoutedEventArgs e)
        {
            //
            // Code
            //
            CloseAllGrid();
            BackgroundForm.Visibility = Visibility.Visible;
        }

        // Set all value in default
        private void ClearClientAccident_Click(object sender, RoutedEventArgs e)
        {
            // Set default client
            ClientClientAccident_TextBox.Text = "";
            ClientClientAccident_LostFocus(ClientClientAccident_TextBox, null);
            // Set default accident
            AccidentClientAccident_ComboBox.Text = "";
            // Set default data
            DataClientAccident_DatePicker.Text = "";
        }

        // Cancel our value
        private void CancelClientAccident_Click(object sender, RoutedEventArgs e)
        {
            ClearClientAccident_Click(null, null);
            // Exit
            CloseAllGrid();
            BackgroundForm.Visibility = Visibility.Visible;
        }

        ///////////////////////////////////////
        ////          CLIENT INFO          ////
        ///////////////////////////////////////

        private void ClientInfoForm_Click(object sender, RoutedEventArgs e)
        {
            CloseAllGrid();
            ClientInfoForm.Visibility = Visibility.Visible;

            // Clean old value
            ClearClientInfo_Click(null, null);
        }

        // Got and lost focus id client
        private void ClientIdInfo_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= ClientIdInfo_GotFocus;
        }

        private void ClientIdInfo_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Client ID";
                ((TextBox)sender).GotFocus += ClientIdInfo_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                try
                {
                    Convert.ToInt32(((TextBox)sender).Text);
                }
                catch
                {
                    ResultValidation = false;
                }
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Checked
        private void AllClient_Checked(object sender, RoutedEventArgs e)
        {
            ClientIdInfo_TextBox.Background = new SolidColorBrush(Colors.Gainsboro);
            ClientIdInfo_TextBox.BorderBrush = new SolidColorBrush(Colors.Silver);
            ClientIdInfo_TextBox.Foreground = new SolidColorBrush(Colors.Silver);
            ClientIdInfo_TextBox.FontStyle = FontStyles.Italic;
            ClientIdInfo_TextBox.Text = "All clients";
            ClientIdInfo_TextBox.IsReadOnly = true;
        }

        // Unchecked
        private void AllClient_Unchecked(object sender, RoutedEventArgs e)
        {
            ClientIdInfo_TextBox.Background = new SolidColorBrush(Colors.White);
            ClientIdInfo_TextBox.Foreground = new SolidColorBrush(Colors.Black);
            ClientIdInfo_TextBox.Text = "";
            ClientIdInfo_TextBox.IsReadOnly = false;
            ClientIdInfo_LostFocus(ClientIdInfo_TextBox, null);
        }

        // Got and lost focus source
        private void SourceInfo_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBox)sender).FontStyle = FontStyles.Normal;
            ((TextBox)sender).Text = "";
            ((TextBox)sender).GotFocus -= SourceInfo_GotFocus;
        }

        private void SourceInfo_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Silver);
                ((TextBox)sender).FontStyle = FontStyles.Italic;
                ((TextBox)sender).Text = "Source";
                ((TextBox)sender).GotFocus += SourceInfo_GotFocus;
            }
            else
            {
                // Check validation enter value
                bool ResultValidation = true;
                //
                // Code validation enter value
                //
                if (ResultValidation)
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Silver);
                }
                else
                {
                    ((TextBox)sender).BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
        }

        // Save our value
        private void SaveClientInfo_Click(object sender, RoutedEventArgs e)
        {
            //
            // Code
            //
            CloseAllGrid();
            BackgroundForm.Visibility = Visibility.Visible;
        }

        // OpenFileDounload
        private void OpenFileDownload_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();

            // Set filter for file extension and default file extension
            dlg.DefaultExt = ".xlsx";
            dlg.Filter = "Exel File (.xls)|*.xls|TXT File (.txt)|*.txt|Word File (.doc)|*.doc";

            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox
            if (result == true)
            {
                // Save file
                using (StreamWriter sw = new StreamWriter(dlg.FileName))
                {
                   sw.WriteLine("1");
                }

                // Set source
                SourceInfo_TextBox.Foreground = new SolidColorBrush(Colors.Black);
                SourceInfo_TextBox.FontStyle = FontStyles.Normal;
                SourceInfo_TextBox.Text = dlg.FileName;
            }
        }

        // Set all value in default
        private void ClearClientInfo_Click(object sender, RoutedEventArgs e)
        {
            // Set default client
            ClientIdInfo_TextBox.Text = "";
            ClientIdInfo_LostFocus(ClientIdInfo_TextBox, null);
            // Set default check box
            AllClient_CheckBox.IsChecked = false;
            // Set default source
            SourceInfo_TextBox.Text = "";
            SourceInfo_LostFocus(SourceInfo_TextBox, null);
        }

        // Cancel our value
        private void CancelClientInfo_Click(object sender, RoutedEventArgs e)
        {
            ClearClientInfo_Click(null, null);
            // Exit
            CloseAllGrid();
            BackgroundForm.Visibility = Visibility.Visible;
        }

        ///////////////////////////////////////
        ////         ABOUT PROGRAM         ////
        ///////////////////////////////////////
        private void AboutProgram_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Проект \"Страховая компания\" написан в учебных целях и не предназначается для коммерческого использования. Все попытки стырить код будут пресечены и наказаны по закону!\n\nВ настоящее время в разных сферах деятельности существуют определенные риски, влекущие за собой финансовые сложности. К таким можно отнести риск потери имущества, причинение вреда здоровью и т.д. Именно поэтому на сегодняшний день существует множество компаний, осуществляющие услуги по страхованию. Проект «Страховая компания» предназначен для более комфортного взаимодействия страховой компании и её клиентов.\n\nПотенциальными заказчиками данного проекта являются страховые компании.В данном приложении клиент сможет найти интересующую его информацию о работе страховой компании, подать заявку на оформление полиса или получении выплат по страховым случаям.Страховые агенты получают удобный способ представления информации о клиентах, что в разы увеличивает их трудоспособность.\n\nДрозд Алексей Игоревич\nЛяшевич Александр Сергеевич\nРоманчук Константин Алексеевич", "About program", MessageBoxButton.OK, MessageBoxImage.Question);
        }
    }
}
