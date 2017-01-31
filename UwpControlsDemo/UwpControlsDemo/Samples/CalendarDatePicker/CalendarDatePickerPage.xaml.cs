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
    public partial class CalendarDatePickerPage : Page
    {
        public CalendarDatePickerPage()
        {
            this.InitializeComponent();

            Actions = new ObservableCollection<string>();
        }

        public ObservableCollection<string> Actions { get; }


        private void OnCalendarViewDayItemChanging(CalendarView sender, CalendarViewDayItemChangingEventArgs e)
        {
            AddAction("CalendarViewDayItemChanging");
        }

        private void OnDateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            AddAction("DateChanged");
        }

        private void OnClosed(object sender, object e)
        {
            AddAction("Closed");
        }

        private void OnOpened(object sender, object e)
        {
            AddAction("Opened");
        }

        private void AddAction(string action)
        {
            Actions.Add(action);
        }


     
    }
}
