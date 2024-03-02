using PackPlaygroud.Model;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace PackPlaygroud.View
{
    /// <summary>
    /// Interaction logic for PackControl.xaml
    /// </summary>
    public partial class PackControl : UserControl, INotifyPropertyChanged
    {
        private PackContainer _pack;

        public PackContainer Pack
        {
            get => _pack;
            set
            {
                if (Equals(value, _pack)) return;
                _pack = value;
                OnPropertyChanged();
            }
        }

        public PackControl()
        {
            DataContext = this;
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            FrameworkElement fe = sender as FrameworkElement;
            ((PackControl)fe.DataContext).Pack.BuyPack();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
