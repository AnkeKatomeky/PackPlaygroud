using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PackPlaygroud.Model
{
    public class PackItem
    {
        public string Name { get; set; }
        public BitmapImage Icon { get; set; }
        public int Quantity { get; set; }
    }
}
