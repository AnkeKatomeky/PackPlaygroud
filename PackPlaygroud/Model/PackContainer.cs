using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PackPlaygroud.Model
{
    public class PackContainer
    {
        public string Name { get; set; }
        public BitmapImage Icon { get; set; }
        public decimal Cost { get; set; }
        public List<PackItem> PackItems { get; set; }


        public void BuyPack()
        {
            MessageBox.Show($"{Name} just purchased by {Cost}");
        }
    }
}
