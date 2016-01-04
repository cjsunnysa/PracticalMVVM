using PracticalMVVM.DataTypes;
using Prism.Events;

namespace PracticalMVVM.AggregateEvents
{
    internal class SelectedCoffeeChangedEvent : PubSubEvent<Coffee>
    {    }
}