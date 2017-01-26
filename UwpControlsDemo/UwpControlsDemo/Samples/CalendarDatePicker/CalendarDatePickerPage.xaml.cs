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
            var content = DateTime.Now.ToString("HH:mm:ss") + " " + action;
            Actions.Add(content);
        }


        /// <summary>
        //  从指定元素获取 MyProperty 依赖项属性的值。
        /// </summary>
        /// <param name="obj">The element from which the property value is read.</param>
        /// <returns>MyProperty 依赖项属性的值</returns>
        public static int GetMyProperty(DependencyObject obj)
        {
            return (int)obj.GetValue(MyPropertyProperty);
        }

        /// <summary>
        /// 将 MyProperty 依赖项属性的值设置为指定元素。
        /// </summary>
        /// <param name="obj">The element on which to set the property value.</param>
        /// <param name="value">The property value to set.</param>
        public static void SetMyProperty(DependencyObject obj, int value)
        {
            obj.SetValue(MyPropertyProperty, value);
        }

        /// <summary>
        /// 标识 MyProperty 依赖项属性。
        /// </summary>
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.RegisterAttached("MyProperty", typeof(int), typeof(CalendarDatePickerPage), new PropertyMetadata(default(int), OnMyPropertyChanged));


        private static void OnMyPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            CalendarDatePickerPage target = obj as CalendarDatePickerPage;
            int oldValue = (int)args.OldValue;
            int newValue = (int)args.NewValue;
            if (oldValue != newValue)
                target.MyPropertyChanged(oldValue, newValue);
        }

        protected virtual void MyPropertyChanged(int oldValue, int newValue)
        {
        }
    }
}
