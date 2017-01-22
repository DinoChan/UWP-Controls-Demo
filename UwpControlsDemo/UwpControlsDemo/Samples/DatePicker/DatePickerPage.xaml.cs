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
    public sealed partial class DatePickerPage : Page
    {
        public DatePickerPage()
        {
            this.InitializeComponent(); Actions = new ObservableCollection<string>();
        }

        public ObservableCollection<string> Actions { get; }

        private void OnDateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            AddAction("DateChanged");
        }


        private void AddAction(string action)
        {
            var content = DateTime.Now.ToString("HH:mm:ss") + " " + action;
            Actions.Add(content);
        }

     
    }
}
