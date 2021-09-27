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

namespace WPF_ContactList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string[] lines = File.ReadAllLines("contacts.txt");

            for (int i = 1; i < lines.Length; i++)
            {
                //0      1           2          3       4
                //Id | FirstName | LastName | Email | Photo
                //1 | Kerwinn | Moriarty | kmoriarty0@state.gov | https://kelicommheadshots.com/wp-content/uploads/2019/02/Jen-for-Social-Media-2-256x256.jpg
                string[] pieces = lines[i].Split('|');
                Contact c = new Contact(Convert.ToInt32(pieces[0]), pieces[1], pieces[2], pieces[3], pieces[4]);
                // c.FirstName = pieces[1];

                lstContacts.Items.Add(c);
            }

        }

        private void btnShowDetails_Click(object sender, RoutedEventArgs e)
        {
            Contact selected = (Contact)lstContacts.SelectedItem;

            imgPhoto.Source = new BitmapImage(new Uri(selected.Photo));

            txtEmail.Text = selected.Email;
            txtFirst.Text = selected.FirstName;
            txtLast.Text = selected.LastName;

        }
    }
}
