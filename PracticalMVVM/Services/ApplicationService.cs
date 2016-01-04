using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalMVVM.Services
{
    internal sealed class ApplicationService
    {
        private ApplicationService() { }

        private static readonly ApplicationService _instance = new ApplicationService();
        private IEventAggregator _eventAggregator;
        

        internal static ApplicationService Instance
        {
            get { return _instance; }
        }

        internal IEventAggregator EventAggregator
        {
            get
            {
                if (_eventAggregator == null)
                    _eventAggregator = new EventAggregator();

                return _eventAggregator;
            }
        }
    }
}
