using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace JSON_Serialization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Game> AllGames = new List<Game>();
        public MainWindow()
        {
            InitializeComponent();

            string[] linesOfFile = File.ReadAllLines("all_games.csv");
            cboPlatforms.Items.Add("All");
            for (int i = 1  ; i < linesOfFile.Length; i++)
            {

                //0         1           2           3        4          5
                //name platform    release_date summary meta_score user_review
                string[] pieces = linesOfFile[i].Split(',');
                Game g = new Game()
                {
                    name = pieces[0].Trim(),
                    platform = pieces[1].Trim(),
                    release_date = Convert.ToDateTime(pieces[2]),
                    summary = pieces[3].Trim(),
                    meta_score = Convert.ToInt32(pieces[4]),
                    user_review = pieces[5].Trim()
                };

                AllGames.Add(g);

                lstGames.Items.Add(g);
                
                if (cboPlatforms.Items.Contains(g.platform) == false)
                {
                    cboPlatforms.Items.Add(g.platform); 
                }
            }

            lblCount.Content = $"Record Count: {lstGames.Items.Count.ToString("N0")}";

        }

        private void cboPlatforms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string platform = cboPlatforms.SelectedValue.ToString();
            //string platform = (string)cboPlatforms.SelectedItem;

            lstGames.Items.Clear();
            foreach (Game game in AllGames)
            {
                if (game.platform == platform)
                {
                    lstGames.Items.Add(game);
                }
            }
            lblCount.Content = $"Record Count: {lstGames.Items.Count.ToString("N0")}";
        }

        private void lstGames_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Game selected = (Game)lstGames.SelectedItem;
            InfoWindow info = new InfoWindow();
            info.PopulateData(selected);

            info.ShowDialog();
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(lstGames.Items, Formatting.Indented);
            File.WriteAllText($"{cboPlatforms.SelectedValue.ToString()}_games.json", json);

        }
    }
}
