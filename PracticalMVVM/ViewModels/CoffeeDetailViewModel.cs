using PracticalMVVM.AggregateEvents;
using PracticalMVVM.DataTypes;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PracticalMVVM
{
    public class CoffeeDetailViewModel : INotifyPropertyChanged
    {
        private Coffee _coffeeDetails;
        private IEventAggregator _eventAggregator;

        public Coffee CoffeeDetails
        {
            get
            {
                return _coffeeDetails;
            }
            set
            {
                if (_coffeeDetails == value)
                    return;

                _coffeeDetails = value;
                OnPropertyChanged("CoffeeDetails");
            }
        }


        public CoffeeDetailViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<SelectedCoffeeChangedEvent>().Subscribe((coffee) => CoffeeDetails = coffee);
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
