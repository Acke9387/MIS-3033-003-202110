using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JSON_Serialization
{
    /// <summary>
    /// Interaction logic for InfoWindow.xaml
    /// </summary>
    public partial class InfoWindow : Window
    {
        public InfoWindow()
        {
            InitializeComponent();
        }

        public void PopulateData(Game g)
        {
            txtMetaScore.Text = g.meta_score.ToString();
            txtName.Text = g.name.ToString();
            txtPlatform.Text = g.platform.ToString();
            txtReleaseDate.Text = g.release_date.ToShortDateString();
            txtSummary.Text = g.summary.ToString();
            txtUserReview.Text = g.user_review.ToString();

            Title = $"{g.name}'s Information";
        }

    }
}
