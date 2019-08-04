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
//using System.Drawing.Image;

namespace ShowPictures
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Dictionary<string, List<string>> photos()
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            dictionary.Add("Cats", new List<string> { "cat01", "cat02", "cat03", "cat04", "cat05", "cat06" });
            dictionary.Add("Cars", new List<string> { "cars01", "cars02", "cars03", "cars04", "cars05", "cars06" });
            dictionary.Add("Fruit", new List<string> { "fruit01", "fruit02", "fruit03", "fruit04", "fruit05", "fruit06" });
            dictionary.Add("Vegetables", new List<string> { "vege01", "vege02", "vege03", "vege04" });
            dictionary.Add("Houses", new List<string> { "house01", "house02", "house03", "house04", "house05", "house06", "house07" }); 

            return dictionary;
        }

        public MainWindow()
        {
            InitializeComponent();



            List<string> categories = new List<string>();

            foreach(KeyValuePair<string, List<string>> dict in photos())
            {
                categories.Add(dict.Key);
            }

            CategorieList.ItemsSource = categories;
        }

        private void DisplayImages_Handler(object sender, SelectionChangedEventArgs e)
        {
            List<string> photoList = new List<string>();

            string category = (sender as ListBox).SelectedValue.ToString();

            if (photos().ContainsKey(category))
            {
                foreach (string photo in photos()[category])
                {
                    photoList.Add(photo);
                }
            }

            Grid pictureGrid = new Grid();
            pictureGrid.Background = new SolidColorBrush(Colors.Bisque);
            Grid.SetRow(pictureGrid, 0);
            Grid.SetColumn(pictureGrid, 1);
            MainGrid.Children.Add(pictureGrid);

            int rows = photoList.Count / 3;
            int partrow = photoList.Count % 3;

            int columns = photoList.Count / 3;
            int partcolumn = photoList.Count % 3;

            string t1 = $"{rows} - {partrow} - {columns} - {partcolumn}";

            for (int i = 0; i < rows; i++)
            {
                pictureGrid.RowDefinitions.Add(new RowDefinition()
                {
                    Height = new GridLength(1, GridUnitType.Star)                    
                });
            }

            for (int i = 0; i < 3; i++)
            {
                pictureGrid.ColumnDefinitions.Add(new ColumnDefinition()
                {
                    Width = new GridLength(1, GridUnitType.Star)
                });
            }

            for (int i = 0; i < partrow; i++)
            {
                pictureGrid.RowDefinitions.Add(new RowDefinition()
                {
                    Height = new GridLength(1, GridUnitType.Star)
                });
            }

            for (int i = 0; i < partcolumn; i++)
            {
                pictureGrid.ColumnDefinitions.Add(new ColumnDefinition()
                {
                    Width = new GridLength(1, GridUnitType.Star)
                });
            }

            foreach (string s in photoList)
            {
                int indexOfPhoto = photoList.IndexOf(s);

                int tempRows = (indexOfPhoto / 3);

                int ict = (indexOfPhoto != 0 && indexOfPhoto % 3 == 0) ? 0 : indexOfPhoto;
                int tempColumn = (ict - (3 * tempRows) < 0) ? 0 : ict - (3 * tempRows);

                string t = $"{tempRows} - {tempColumn}";

                Image image = new Image()
                {
                    Source = new BitmapImage(new Uri($"Images/{category}/{s}.jpg", UriKind.RelativeOrAbsolute)),
                    Width = pictureGrid.Width / 3,
                    Height = 100,
                    Margin = new Thickness(10, 10, 10, 10)
                };

                image.MouseDown += new MouseButtonEventHandler(SelectedImage_Handler);

                pictureGrid.Children.Add(image);
                Grid.SetColumn(image, tempColumn);
                Grid.SetRow(image, tempRows);
                
            }
            
        }

        private void SelectedImage_Handler(object sender, RoutedEventArgs e)
        {
            SelectedImage.Source = new BitmapImage(new Uri((sender as Image).Source.ToString() , UriKind.RelativeOrAbsolute));

            SelectedImage.Width = 300;
            SelectedImage.Height = (sender as Image).Height;

            WidthImage.Content = $"Width:\t{(sender as Image).Source.Width} px";
            HeightImage.Content = $"Height:\t{(sender as Image).Source.Height} px";

            WidthImage.Margin = new Thickness(10);
            HeightImage.Margin = new Thickness(10);

            SelectedImage.Margin = new Thickness(0, 50, 0, 0);
        }
    }
}
