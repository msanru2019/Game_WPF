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
using MahApps.Metro.Controls;

namespace Final_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        
        
        List<Game>game = new List<Game>();
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }
        void Initialize()
        {
            using (var db = new GamesDBEntities())
            {
                game = db.Games.ToList();
            }
            
        }


        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            FlyData.IsOpen = true;
        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 _ver = new Window1();
            this.Close();
            _ver.ShowDialog();
        }

        private void Tile_Click_2(object sender, RoutedEventArgs e)
        {
            Window2 _san = new Window2();
            this.Close();
            _san.ShowDialog();
        }

        private void Tile_Click_3(object sender, RoutedEventArgs e)
        {
            Window3 _sa = new Window3();
            this.Close();
            _sa.ShowDialog();
        }

        private void Tile_Click_4(object sender, RoutedEventArgs e)
        {
            Window4 _sr = new Window4();
            this.Close();
            _sr.ShowDialog();
        }

        private void Sign_btn_Click_1(object sender, RoutedEventArgs e)
        {
            if (Ply2_txt.Text == "" || Ply1_txt.Text == "")
            {
                MessageBox.Show("Please enter name");
            }
            else
            {


                string Py1name = Ply1_txt.Text;
                string Py2name = Ply2_txt.Text;

                using (var db = new GamesDBEntities())
                {
                    Game newgame = new Game();
                    newgame.Name = Ply1_txt.Text;
                    newgame.PingPong = 0;
                    newgame.Quiz = 0;
                    newgame.Catch = 0;
                    db.Games.Add(newgame);
                    db.SaveChanges();

                    Game newgame1 = new Game();
                    newgame1.Name = Ply2_txt.Text;
                    newgame1.PingPong = 0;
                    newgame1.Quiz = 0;
                    newgame1.Catch = 0;
                    db.Games.Add(newgame1);
                    db.SaveChanges();

                }

            }
        }

    }  
}
