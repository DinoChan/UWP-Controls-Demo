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
    public sealed partial class AutoSuggestBoxPage : Page, INotifyPropertyChanged
    {
        public AutoSuggestBoxPage()
        {
            this.InitializeComponent();
            Actions = new ObservableCollection<string>();
            var _itemsSourceCore = new ObservableCollection<string>();
            for (int i = 0; i < 10000; i++)
            {
                _itemsSourceCore.Add(i.ToString());
            }
            UpdateItemsSource(string.Empty);
        }


        public ObservableCollection<string> Actions { get; }


        private IEnumerable<string> _itemsSource;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 获取或设置 Property 的值
        /// </summary>
        public IEnumerable<string> ItemsSource
        {
            get { return _itemsSource; }
            set
            {
                if (_itemsSource == value)
                    return;

                _itemsSource = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(ItemsSource)));
            }
        }

        private ObservableCollection<string> _itemsSourceCore;

        private void AddAction(string action)
        {
            Actions.Add(action);
        }

        private void OnQuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            AddAction("QuerySubmitted");
            if (args.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // Use args.QueryText to determine what to do.
            }
        }

        private void OnSuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            AddAction("SuggestionChosen");
            sender.Text = (string)args.SelectedItem;
        }

        private void OnTextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            AddAction("TextChanged");
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                UpdateItemsSource(sender.Text);
            }
        }

        private void UpdateItemsSource(string filter)
        {
            ItemsSource = _itemsSourceCore.Where(i => i.StartsWith(filter));
        }
    }
}