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
using MapClasses;
using System.Reflection;



namespace PieceOfShip
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Image background;
        public Map map;
        public Grid mapGrid;
    
        /// <summary>
        /// Purpose: 
        /// </summary>
        private void loadBackgroundImage()
        {
            
            Uri uri = new Uri(@"pack://application:,,,/" + Assembly.GetCallingAssembly().GetName() + ";component/" + map.getCurrentMapTileLocation(),
                UriKind.Absolute);
            BitmapImage finishedImage = new BitmapImage(uri);
            background.Source = finishedImage;
        }

        public MainWindow()
        {
            InitializeComponent();
            map = new Map();
            background = new Image();
            mapGrid = new Grid();
            Grid.SetColumn(background, 0);
            Grid.SetRow(background, 0);
            mapGrid.Children.Add(background);
            loadBackgroundImage();
            Window.GetWindow(this).Content = mapGrid;
            
        }
    }
}
