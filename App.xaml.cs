using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using SplashScreen = CompanyApp.Startup.SplashScreen;

namespace CompanyApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.Show();
            
            var startupTask = new Task(() =>
            {
                Random value = new Random();
                //Load plugins in non-UI thread - may be time consuming
                for (int percent = 0; percent < 100; )
                {
                    percent += value.Next(0, 10);
                    if (percent > 100) percent = 100;
                    //set custom message on screen
                    splashScreen.Dispatcher.BeginInvoke(
                        (Action)(() => splashScreen.Message = "Loading " + percent + "/100"));
                        
                    
                    
                    Thread.Sleep(value.Next(0, 200));
                }
            });

            //when plugin loading finished, show main window
            startupTask.ContinueWith(t =>
            {
                MainWindow mainWindow = new MainWindow();

                //when main windows is loaded close splash screen
                mainWindow.Loaded += (sender, args) => splashScreen.Close();

                //set application main window;
                this.MainWindow = mainWindow;

                //and finally show it
                mainWindow.Show();
            }, TaskScheduler.FromCurrentSynchronizationContext());

            startupTask.Start();
        }
    }

    
}
