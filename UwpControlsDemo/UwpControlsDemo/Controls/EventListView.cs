using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;

namespace UwpControlsDemo
{
    public class EventListView : ListView
    {
        public EventListView()
        {
            _items = new Dictionary<object, DateTime>();
        }

        //protected override DependencyObject GetContainerForItemOverride()
        //{
        //    return new EventListViewItem();
        //}


        private Dictionary<object, DateTime> _items;

        protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
        {
            base.PrepareContainerForItemOverride(element, item);
            return;
            var eventListViewItem = element as EventListViewItem;
            var time = _items[item];
            eventListViewItem.Content = item;
            eventListViewItem.Header = time.ToString("HH:mm:ss ffff");
        }


        protected override void OnItemsChanged(object e)
        {
            base.OnItemsChanged(e);
            foreach (var item in Items)
            {
                if (_items.ContainsKey(item) == false)
                    _items.Add(item, DateTime.Now);
            }
        }
    }
}
