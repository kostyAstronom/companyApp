using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;

namespace CompanyApp.Startup
{
    /// <summary>
    /// Логика взаимодействия для SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen
    {
        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(SplashScreen),
                                        new UIPropertyMetadata(null, OnMessageChanged));
        public SplashScreen()
        {
            this.InitializeComponent();
        }
            
        public string Message
        {
            get { return (string)this.GetValue(MessageProperty); }
            set { this.SetValue(MessageProperty, value); }
        }
        
        public event EventHandler MessageChanged;

        private void RaiseMessageChanged(EventArgs e)
        {
            EventHandler handler = this.MessageChanged;
            if (handler != null) handler(this, e);
        }

        private static void OnMessageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SplashScreen splashScreen = (SplashScreen)d;
            splashScreen.RaiseMessageChanged(EventArgs.Empty);
        }
    }
}
