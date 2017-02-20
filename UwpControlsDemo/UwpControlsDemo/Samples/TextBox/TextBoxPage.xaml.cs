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
    public sealed partial class TextBoxPage : Page
    {
        public TextBoxPage()
        {
            this.InitializeComponent();
            Actions = new ObservableCollection<string>();
            ScrollModes = new List<ScrollMode> { ScrollMode.Auto, ScrollMode.Disabled, ScrollMode.Enabled };
            ScrollBarVisibilities = new List<ScrollBarVisibility> { ScrollBarVisibility.Auto, ScrollBarVisibility.Disabled, ScrollBarVisibility.Hidden, ScrollBarVisibility.Visible };
            TextWrappings = new List<TextWrapping> { TextWrapping.NoWrap, TextWrapping.Wrap, TextWrapping.WrapWholeWords };
        }

        public ObservableCollection<string> Actions { get; }

        public IEnumerable<ScrollMode> ScrollModes { get; }

        public IEnumerable<ScrollBarVisibility> ScrollBarVisibilities { get; }

        public IEnumerable<TextWrapping> TextWrappings { get; }



        private void AddAction(string action)
        {
            Actions.Add(action);
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            AddAction("OnTextChanged");
        }
    }
}
