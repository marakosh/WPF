using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Movie_Information.Services;

namespace Movie_Information
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
        private async void search_btn_Click(object sender, RoutedEventArgs e)
        {
            string ResultSearch = await DownloadService.FindMovie(search_box.Text);

            var titlesearch = DeserializeService.Deserialize(ResultSearch);
            if (titlesearch != null)
            {
                name_text.Text = $"Country: {titlesearch.Country}";
                ratings_text.Text = $"Rating: {titlesearch.Ratings?[0].Value ?? "not found"}";
                year_text.Text = $"Year: {titlesearch.Year}";
                writer_text.Text = $"Writer: {titlesearch.Writer}";
                poster.Text = "Poster";
                plot_text.Text = titlesearch.Plot;
                actors_text.Text = titlesearch.Actors;
                genre_text.Text = titlesearch.Genre;
                if (titlesearch.Poster != null)
                {
                   image.Source = new BitmapImage(new Uri(titlesearch.Poster));
                }
            }
            search_box.Text = "";
        }
    }
}
