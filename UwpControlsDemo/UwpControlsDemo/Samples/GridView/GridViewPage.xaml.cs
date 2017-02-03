using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace UwpControlsDemo
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class GridViewPage : Page, INotifyPropertyChanged
    {
        public GridViewPage()
        {
            this.InitializeComponent();
            Actions = new ObservableCollection<string>();
            SelectionModes = new List<ListViewSelectionMode> { ListViewSelectionMode.Extended, ListViewSelectionMode.Multiple, ListViewSelectionMode.Single, ListViewSelectionMode.None };
            Items = new ObservableCollection<int>();
            for (int i = 0; i < 20; i++)
            {
                AddItem();
            }
            SelectedItems = new ObservableCollection<int>();
        }


        public ObservableCollection<string> Actions { get; }

        public IEnumerable<ListViewSelectionMode> SelectionModes { get; }

        public ObservableCollection<int> Items { get; private set; }

        public bool CanRemoveItems
        {
            get
            {
                return _canRemoveItems;
            }

            set
            {
                if (_canRemoveItems == value)
                    return;

                _canRemoveItems = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(CanRemoveItems)));
            }
        }

        public ObservableCollection<int> SelectedItems { get; private set; }

        private bool _canRemoveItems;

        private int _index;

        public event PropertyChangedEventHandler PropertyChanged;

        private void AddAction(string action)
        {
            Actions.Add(action);
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddAction("SelectionChanged");
            CanRemoveItems = GridView.SelectedItems.Any();
            SelectedItems.Clear();
            foreach (var item in GridView.SelectedItems)
            {
                SelectedItems.Add((int)item);
            }
        }

        private void AddItem()
        {
            Items.Add(_index++);
        }

        private void RemoveCurrentItems()
        {
            foreach (var item in GridView.SelectedItems.ToList())
            {
                Items.Remove((int)item);
            }
        }

        private void OnAddItem(object sender, RoutedEventArgs e)
        {
            AddItem();
        }

        private void OnRemoveItems(object sender, RoutedEventArgs e)
        {
            RemoveCurrentItems();
        }

        private void OnChoosingGroupHeaderContainer(ListViewBase sender, ChoosingGroupHeaderContainerEventArgs args)
        {
            AddAction("ChoosingGroupHeaderContainer");
        }

        private void OnChoosingItemContainer(ListViewBase sender, ChoosingItemContainerEventArgs args)
        {
            AddAction("ChoosingItemContainer");
        }

        private void OnContainerContentChanging(ListViewBase sender, ContainerContentChangingEventArgs args)
        {
            AddAction("ContainerContentChanging");
        }

        private void OnDragItemsCompleted(ListViewBase sender, DragItemsCompletedEventArgs args)
        {
            AddAction("DragItemsCompleted");
        }

        private void OnDragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            AddAction("DragItemsStarting");
        }

        private void OnItemClick(object sender, ItemClickEventArgs e)
        {
            AddAction("ItemClick");
        }
    }
}
