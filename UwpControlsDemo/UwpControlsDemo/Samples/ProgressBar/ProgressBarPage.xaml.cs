using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
    public sealed partial class ProgressBarPage : Page
    {
        public ProgressBarPage()
        {
            this.InitializeComponent();
            Actions = new ObservableCollection<string>();
        }

        public ObservableCollection<string> Actions { get; }


        private void AddAction(string action)
        {
            Actions.Add(action);
        }

        private void OnValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            AddAction("ValueChanged");
        }

        private void OnStartProgress(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            button.IsEnabled = false;
            var max = ProgressBar.Maximum;
            var min = ProgressBar.Minimum;
            Task.Run(
               async () =>
               {
                   var value = min;
                   while (value <= max)
                   {
                       ProgressBar.Value = value;
                       value += (max - min) / 50;
                       value = Math.Min(value, max);
                       await Task.Delay(TimeSpan.FromMilliseconds(200));
                   }
                   button.IsEnabled = true;
               });
        }
    }
}
