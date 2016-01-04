using PracticalMVVM.AggregateEvents;
using PracticalMVVM.DataTypes;
using PracticalMVVM.Services;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalMVVM
{
    public class CoffeeOverviewViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Coffee> _coffees;
        private Coffee _selectedCoffee;
        private CoffeeDataService _dataService;
        private IEventAggregator _eventAggregator;

        public ObservableCollection<Coffee> Coffees
        {
            get
            {
                return _coffees;
            }
            set
            {
                if (_coffees == value)
                    return;

                _coffees = value;
                OnPropertyChanged("Coffees");
            }
        }
        public Coffee SelectedCoffee
        {
            get
            {
                return _selectedCoffee;
            }
            set
            {
                if (_selectedCoffee == value)
                    return;

                _selectedCoffee = value;
                OnPropertyChanged("SelectedCoffee");

                _eventAggregator.GetEvent<SelectedCoffeeChangedEvent>().Publish(value);
            }
        }


        public CoffeeOverviewViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _dataService = new CoffeeDataService();

            LoadData();

            SelectedCoffee = _coffees.First();
        }


        private void LoadData()
        {
            Coffees = new ObservableCollection<Coffee>(_dataService.GetAll());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
