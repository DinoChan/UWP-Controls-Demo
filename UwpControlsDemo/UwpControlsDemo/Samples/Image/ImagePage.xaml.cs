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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace UwpControlsDemo
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ImagePage : Page
    {
        public ImagePage()
        {
            this.InitializeComponent();

            Actions = new ObservableCollection<string>();
            Stretches = new List<Stretch> { Stretch.Fill, Stretch.None, Stretch.Uniform, Stretch.UniformToFill };
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            Image.Source = SourceComboBox.Items.FirstOrDefault() as ImageSource;
        }

        public ObservableCollection<string> Actions { get; }

        public IEnumerable<Stretch> Stretches { get; }


        private void OnImageLoaded(object sender, RoutedEventArgs e)
        {
            AddAction("ImageLoaded");
        }

        private void OnImageOpened(object sender, RoutedEventArgs e)
        {
            AddAction("ImageOpened");
        }

        private void OnImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            AddAction("ImageFailed");
        }

        private void AddAction(string action)
        {
            var content = DateTime.Now.ToString("HH:mm:ss") + " " + action;
            Actions.Add(content);
        }
    }
}
