using System;
using System.Collections.Generic;
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
using System.Collections.ObjectModel;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace UwpControlsDemo
{
    public sealed partial class ButtonSample : UserControl
    {
        public ButtonSample()
        {
            this.InitializeComponent();
            Actions = new ObservableCollection<string>();
            ClickModes = new List<ClickMode> { ClickMode.Hover, ClickMode.Press, ClickMode.Release }; 
        }

        public ObservableCollection<string> Actions { get; }

        public IEnumerable<ClickMode> ClickModes { get; }


        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            var action =  "Clicked";
            Actions.Add(action);
        }
    }
}
