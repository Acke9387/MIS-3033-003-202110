using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JSON_Chuck_Norris_Jokes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cboCategories.Items.Clear();
            cboCategories.Items.Add("all");

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync("https://api.chucknorris.io/jokes/categories").Result;

                var results = JsonConvert.DeserializeObject<List<string>>(json);

                foreach (string category in results)
                {
                    cboCategories.Items.Add(category);
                }

            }

        }
    }
}
