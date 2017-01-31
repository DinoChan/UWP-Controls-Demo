using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class ComboBoxPage : Page
    {
        public ComboBoxPage()
        {
            this.InitializeComponent();
            Actions = new ObservableCollection<string>();
            Items = new ObservableCollection<int>();
            for (int i = 0; i < 10; i++)
            {
                Items.Add(i);
            }
        }

        public ObservableCollection<int> Items { get; private set; }

        public ObservableCollection<string> Actions { get; }


        private void AddAction(string action)
        {
            Actions.Add(action);
        }

        private void OnDropDownOpened(object sender, object e)
        {
            AddAction("DropDownOpened");
        }

        private void OnDropDownClosed(object sender, object e)
        {
            AddAction("DropDownClosed");
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddAction("SelectionChanged");
        }
    }
}
