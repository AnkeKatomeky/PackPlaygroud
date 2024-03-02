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
using PackPlaygroud.Model;

namespace PackPlaygroud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PackContainer PackContainer1 { get; set; }
        public PackContainer PackContainer2 { get; set; }
        public PackContainer PackContainer3 { get; set; }

        public MainWindow()
        {
            //var gem = new ImageSourceConverter().ConvertFromString("pack://application:,,,/PackPlaygroud;/Assets/Gem.png") as ImageSource;
            //var chest = new ImageSourceConverter().ConvertFromString("pack://application:,,,/PackPlaygroud;/Assets/Chest.png") as ImageSource;
            //var pallet = new ImageSourceConverter().ConvertFromString("pack://application:,,,/PackPlaygroud;/Assets/Pallet.png") as ImageSource;

            var gem = new BitmapImage(new Uri(@"Assets/Gem.png", UriKind.Relative));
            var chest = new BitmapImage(new Uri(@"Assets/Chest.png", UriKind.Relative));
            var pallet = new BitmapImage(new Uri(@"Assets/Pallet.png", UriKind.Relative));
            
            var itemList = new List<PackItem>()
            {
                new(){ Icon = gem, Name = "First", Quantity = 6},
                new(){ Icon = gem, Name = "Second", Quantity = 3},
                new(){ Icon = gem, Name = "Kes", Quantity = 7},
                new(){ Icon = gem, Name = "Sex", Quantity = 1},
                new(){ Icon = gem, Name = "Qwe", Quantity = 2},
            };

            PackContainer1 = new PackContainer()
            {
                Name = "Стартовый набор",
                Cost = 120,
                Icon = chest,
                PackItems = itemList
            };

            PackContainer2 = new PackContainer()
            {
                Name = "Набор красок",
                Cost = 370,
                Icon = pallet,
                PackItems = itemList
            };

            PackContainer3 = new PackContainer()
            {
                Name = "Продвинутый набор",
                Cost = 790,
                Icon = chest,
                PackItems = itemList
            };

            InitializeComponent();
            Pack1.Pack = PackContainer1;
            Pack2.Pack = PackContainer2;
            Pack3.Pack = PackContainer3;
        }
    }
}
