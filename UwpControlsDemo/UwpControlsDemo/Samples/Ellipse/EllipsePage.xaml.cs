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
using Windows.UI.Xaml.Shapes;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace UwpControlsDemo
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class EllipsePage : Page
    {
        public EllipsePage()
        {
            this.InitializeComponent();
            PenLineCaps = new List<PenLineCap> { PenLineCap.Flat, PenLineCap.Round, PenLineCap.Square, PenLineCap.Triangle };
            PenLineJoins = new List<PenLineJoin> { PenLineJoin.Bevel, PenLineJoin.Miter, PenLineJoin.Round };
            Stretches = new List<Stretch> { Stretch.Fill, Stretch.None, Stretch.Uniform, Stretch.UniformToFill };
        }

        public IEnumerable<PenLineCap> PenLineCaps { get; }

        public IEnumerable<PenLineJoin> PenLineJoins { get; }

        public IEnumerable<Stretch> Stretches { get; }

        private void OnEnabledDashArrayToggled(object sender, RoutedEventArgs e)
        {
            var dashArray = new DoubleCollection();
            if (EnabledDashArrayElement.IsOn)
            {
                dashArray.Add(SliderDashArray0.Value);
                dashArray.Add(SliderDashArray1.Value);
            }

            Ellipse.StrokeDashArray = dashArray;
        }
    }
}
