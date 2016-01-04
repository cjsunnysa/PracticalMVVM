using PracticalMVVM.DataTypes;
using PracticalMVVM.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for CoffeeOverviewView.xaml
    /// </summary>
    public partial class CoffeeOverviewView : Window
    {
        public CoffeeOverviewView()
        {
            InitializeComponent();

            this.DataContext = new CoffeeOverviewViewModel(ApplicationService.Instance.EventAggregator);

            this.Loaded += CoffeeOverviewView_Loaded;
        }

        private void CoffeeOverviewView_Loaded(object sender, RoutedEventArgs e)
        {
            CoffeeList.Focus();
        }
    }
}
