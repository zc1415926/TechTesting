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

namespace SplashScreenTest
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreenLoaded(object sender, RoutedEventArgs e)
        {
            System.Timers.Timer timerTurnToMainWindow = new System.Timers.Timer(3000);
            timerTurnToMainWindow.Elapsed += new System.Timers.ElapsedEventHandler(OnTimerTurnToMainWindowElapsed);
            timerTurnToMainWindow.Enabled = true;
        }

        private void OnTimerTurnToMainWindowElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            (sender as System.Timers.Timer).Enabled = false;
            App.Current.Dispatcher.Invoke(new Action(() =>
            {
                
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }));

            
        }


    }
}
