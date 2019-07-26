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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : MetroWindow
    {
        GamesDBEntities db;
        Table table;
        public Window4()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            db = new GamesDBEntities();

            gameData.ItemsSource = db.Games.ToList();
        }

        private void Home_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow _sr = new MainWindow();
            this.Close();
            _sr.ShowDialog();
        }

        private void Ping_btn_Click(object sender, RoutedEventArgs e)
        {
            Window1 _sl = new Window1();
            this.Close();
            _sl.ShowDialog();
        }

        private void Memory_btn_Click(object sender, RoutedEventArgs e)
        {
            Window2 _st = new Window2();
            this.Close();
            _st.ShowDialog();
        }

        private void Catch_btn_Click(object sender, RoutedEventArgs e)
        {
            Window3 _tt = new Window3();
            this.Close();
            _tt.ShowDialog();
        }
    }
}
