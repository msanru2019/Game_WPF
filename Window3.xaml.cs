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
using MahApps.Metro.Controls;

namespace Final_Project
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : MetroWindow
    {

        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        public Window3()
        {
            InitializeComponent();
            
            timer.Tick += physics;
            timer.Interval = TimeSpan.FromSeconds(0.05);
        }

        private void ButtonStartStop_Click(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = !timer.IsEnabled;
        }
        bool goingRight = true;
        bool goingDown = true;

        void physics(object sender, EventArgs e)
        {
            double v = 10.0;
            if (checkBoxFast.IsChecked.Value)
            {
                v = 30.0;
            }

            double x = Canvas.GetLeft(ball);
            if (goingRight)
            {
                x += v;
            }
            else
            {
                x -= v;
            }

            if (x + ball.Width > MyCanvas.ActualWidth)
            {
                goingRight = false;
                x = MyCanvas.ActualWidth - ball.Width;
                
                //System.Media.SystemSounds.As.Play();
            }
            else if (x < 0.0)
            {
                goingRight = true;
                x = 0.0;
               // System.Media.SystemSounds.Beep.Play();
            }
            Canvas.SetLeft(ball, x);

            double y = Canvas.GetTop(ball);
            if (goingDown)
            {
                y += v;
            }
            else
            {
                y -= v;
            }

            if (y + ball.Height > MyCanvas.ActualHeight)
            {
                goingDown = false;
                y = MyCanvas.ActualHeight - ball.Height;
                
            }
            else if (y < 0.0)
            {
                goingDown = true;
                y = 0.0;
                //System.Media.SystemSounds.Hand.Play();
            }
            Canvas.SetTop(ball, y);
        }


        int score;

        private void RadioButtonRed_Click(object sender, RoutedEventArgs e)
        {
            ball.Fill = Brushes.Red;
        }

        private void RadioButtonGreen_Click(object sender, RoutedEventArgs e)
        {
            ball.Fill = Brushes.SeaGreen;
        }

        private void RadioButtonBlue_Click(object sender, RoutedEventArgs e)
        {
            ball.Fill = Brushes.RoyalBlue;
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (timer.IsEnabled)
            {
                score++;
                labelScore.Content = $"Player score: {score}";
                
            }
        }

        private void Home_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow _sr = new MainWindow();
            this.Close();
            _sr.ShowDialog();
        }
    }
}
