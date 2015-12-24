using PracticalMVVM.DataTypes;
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
using System.Windows.Shapes;

namespace PracticalMVVM
{
    /// <summary>
    /// Interaction logic for CoffeeDetailView.xaml
    /// </summary>
    public partial class CoffeeDetailView : Window
    {
        public Coffee CoffeeDetail { get; set; }

        public CoffeeDetailView(Coffee coffeeRecord)
        {
            InitializeComponent();

            CoffeeDetail = coffeeRecord;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = CoffeeDetail;
        }
    }
}
