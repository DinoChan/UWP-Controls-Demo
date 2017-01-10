using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UwpControlsDemo
{
    public class PageItemGroup
    {
        public PageItemGroup(string title)
        {
            Items = new ObservableCollection<PageItem>();
            Title = title;
        }

        public string Title { get; private set; }

        public ObservableCollection<PageItem> Items { get; private set; }
    }
}
