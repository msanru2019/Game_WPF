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
using System.Windows.Navigation;
using MahApps.Metro.Controls;

namespace Final_Project
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : MetroWindow
    {
        static int P1counter = 0;
        static int P2counter = 0;

        static string p1Name;
        static string p2Name;

        static int p1ID;
        static int p2ID;

        string m_fullList = "abcdefghijklmnopqrstuvwxyz";
        List<char> m_to_remember = new List<char>();
        List<Game> games = new List<Game>();
        bool isFirstStage;
        Random rand = new Random();
        public Window2()
        {
            InitializeComponent();
            Initialize();
            LoadFirstStage();
        }
        void Initialize()
        {
            using (var db = new GamesDBEntities())
            {
                games= db.Games.ToList();
                var p1 = new Game();
                p1 = db.Games.OrderByDescending(o => o.IdUser).Skip(1).First();
                p1Name = p1.Name;
                p1ID = p1.IdUser;

               
                // save user t
                var p2 = new Game();
                p2 = db.Games.OrderByDescending(o => o.IdUser).First();
                p2Name = p2.Name;
                p2ID = p2.IdUser;
            }
           
            
        }
        private void LoadFirstStage()
        {
            isFirstStage = true;

            for (int i = 0; i < 3; i++)
            {
                int index = rand.Next(m_fullList.Length);
                char temp = m_fullList[index];
                m_to_remember.Add(temp);
                listBox1.Items.Add(temp);
                listBox1.IsEnabled = false;
            }

            play1.Content = $"Player 1 score: {P1counter}";
            play2.Content = $"Player 2 score: {P2counter}";
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (isFirstStage)
            {
                listBox1.Items.Clear();
                listBox1.IsEnabled = true;
                listBox1.SelectionMode = SelectionMode.Multiple;

                for (int s = 0; s < m_fullList.Length; s++)
                {
                    listBoxply1.Items.Add(m_fullList[s]);
                    listBoxply2.Items.Add(m_fullList[s]);
                }
                isFirstStage = false;
                label_message.Content = "What were the previous letters";
            }
            
           
           
                

            

        }

        private void Button1_reset_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();

            m_to_remember.Clear();

            LoadFirstStage();
            label_message.Content = "You ready for next round";
        }

        private void Play1_btn_Click(object sender, RoutedEventArgs e)
        {
            Boolean winner = true;
            for (int i = 0; i < listBoxply1.SelectedItems.Count; i++)
            {
                char selectedChar = listBoxply1.SelectedItems[i].ToString()[0];
                if (m_to_remember.Contains(selectedChar) == false)
                {
                    winner = false;
                    break;
                }
                if (winner)
                {
                    P1counter++;
                    play1.Content = $"Player 1 score: {P1counter}";
                }


                else
                    MessageBox.Show("Wrong Try again!");
            }
        }

        private void Play2_btn_Click(object sender, RoutedEventArgs e)
        {
            Boolean winner = true;
            for (int j = 0; j < listBoxply2.SelectedItems.Count; j++)
            {
                char selectedChar = listBoxply2.SelectedItems[j].ToString()[0];
                if (m_to_remember.Contains(selectedChar) == false)
                {
                    winner = false;
                    break;
                }
                if (winner)
                {
                    P2counter++;
                    play2.Content = $"Player 2 score: {P2counter}";

                    using (var db = new GamesDBEntities())
                    {
                        Game updateply1 = new Game();
                        updateply1 = db.Games.Find(p1ID);
                        updateply1.Quiz = P1counter;
                        db.SaveChanges();

                        Game updateply2 = new Game();
                        updateply2 = db.Games.Find(p2ID);
                        updateply2.Quiz = P2counter;
                        db.SaveChanges();


                    }
                }

                else
                    MessageBox.Show("Wrong Try again!");

            }
        }

        private void Home_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow _sr = new MainWindow();
            this.Close();
            _sr.ShowDialog();
        }

        private void Pinpng_btn_Click(object sender, RoutedEventArgs e)
        {
            Window1 _sl = new Window1();
            this.Close();
            _sl.ShowDialog();
        }

        private void Catch_btn_Click(object sender, RoutedEventArgs e)
        {
            Window3 _tt = new Window3();
            this.Close();
            _tt.ShowDialog();
        }

        private void Stat_btn_Click(object sender, RoutedEventArgs e)
        {
            Window4 _tt = new Window4();
            this.Close();
            _tt.ShowDialog();
        }
    }

}

