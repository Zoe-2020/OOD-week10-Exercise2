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

namespace week10_Exercise2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ComputerGameData db;
        

   

        private void ComputerGamesLbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComputerGame selectedComputerGame = ComputerGamesLbx.SelectedItem as ComputerGame;

            if (selectedComputerGame != null)
            {
                var query = from a in db.Characters
                            where a.ComputerGameID == selectedComputerGame.ComputerGameID
                            select a;


                CharactersLbx.ItemsSource = query.ToList();

            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new ComputerGameData();

            var query = from c in db.ComputerGames
                        select c;

            ComputerGamesLbx.ItemsSource = query.ToList();
        }
    }
}
