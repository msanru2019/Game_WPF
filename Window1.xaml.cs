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
using System.Windows.Threading;
using MahApps.Metro.Controls;

namespace Final_Project
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : MetroWindow
    {
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        double vx = 140.0;
        double vy = 160.0;

        Ball ball;
        Pale jug1, jug2;
        DispatcherTimer dp;
        int pj1 = 0, pj2 = 0;
        static string p1Name;
        static string p2Name;

        static int p1ID;
        static int p2ID;
        List<Game> games = new List<Game>();
        public Window1()
        {
            InitializeComponent();
            Initialize();
            dp = new DispatcherTimer();
            dp.Interval = new TimeSpan(0, 0, 0, 0, 19);
            dp.Tick += new EventHandler(dp_tick);
            ball = new Ball(canvas);
            jug1 = new Pale(canvas, 20);
            jug2 = new Pale(canvas, 530);

           
        }
        void Initialize()
        {
            using (var db = new GamesDBEntities())
            {
                games = db.Games.ToList();
                var p1 = new Game();
                p1 = db.Games.OrderByDescending(o => o.IdUser).Skip(1).First();
                p1Name = p1.Name;
                p1ID = p1.IdUser;

                var p2 = new Game();
                p2 = db.Games.OrderByDescending(o => o.IdUser).First();
                p2Name = p2.Name;
                p2ID = p2.IdUser;
            }


        }
       
            private void MetroWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                jug1.baj();
            }
            if (e.Key == Key.Up)
            {
                jug1.sub();
            }
            if (e.Key == Key.W)
            {
                jug2.sub();
            }
            if (e.Key == Key.S)
            {
                jug2.baj();
            }
        }

        private void MetroWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                jug1.para();
            }
            if (e.Key == Key.Up)
            {
                jug1.para();
            }
            if (e.Key == Key.W)
            {
                jug2.para();
            }
            if (e.Key == Key.S)
            {
                jug2.para();
            }
        }

        private void Instruct_Click(object sender, RoutedEventArgs e)
        {
            FlyData2.IsOpen = true;
        }


        private void Home_button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow _rr = new MainWindow();
            this.Close();
            _rr.ShowDialog();
        }

        private void Memory_btn_Click(object sender, RoutedEventArgs e)
        {
            Window2 _st = new Window2();
            this.Close();
            _st.ShowDialog();
        }

        private void Catch_btn_Click(object sender, RoutedEventArgs e)
        {
            Window3 _st = new Window3();
            this.Close();
            _st.ShowDialog();
        }

        private void Stat_btn_Click(object sender, RoutedEventArgs e)
        {
            Window4 _st = new Window4();
            this.Close();
            _st.ShowDialog();
        }

        private void Playpause_Click_1(object sender, RoutedEventArgs e)
        {
            if (dp.IsEnabled)
            {
                dp.IsEnabled = false;
                playpause.Content = "Continue";
            }
            else
            {
                dp.IsEnabled = true;
                playpause.Content = "Pause";
            }
        }

        public void dp_tick(object sender, EventArgs e)
        {
            ball.movement();
            jug1.movement();
            jug2.movement();
            if (ball.x <= 0)
            {
                ball.retex();
                pj2++;
                j2.Content = pj2;

                using (var db = new GamesDBEntities())
                {
                    Game updateply1 = new Game();
                    updateply1 = db.Games.Find(p1ID);
                    updateply1.PingPong = pj2;
                    db.SaveChanges();


                }
            }
            if (ball.x >= 570)
            {
                ball.retex();
                pj1++;
                j1.Content = pj1;

                using (var db = new GamesDBEntities())
                {
                    Game updateply2 = new Game();
                    updateply2 = db.Games.Find(p2ID);
                    updateply2.PingPong = pj1;
                    db.SaveChanges();


                }
            }
            if (ball.y <= 0 || ball.y >= 250)
            {
                ball.retey();
            }
            if (ball.x <= (jug1.x + jug1.w) && ball.y >= jug1.y && ball.y <= (jug1.y + jug1.h))
            {
                ball.retex();
            }
            if ((ball.x + ball.t) >= jug2.x && ball.y >= jug2.y && ball.y <= (jug2.y + jug2.h))
            {
                ball.retex();
            }

        }



    }
}
