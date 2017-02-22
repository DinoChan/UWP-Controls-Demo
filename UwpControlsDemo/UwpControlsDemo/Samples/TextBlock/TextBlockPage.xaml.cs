using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Text;
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
    public sealed partial class TextBlockPage : Page
    {
        public TextBlockPage()
        {
            this.InitializeComponent();
            ScrollModes = new List<ScrollMode> { ScrollMode.Auto, ScrollMode.Disabled, ScrollMode.Enabled };
            ScrollBarVisibilities = new List<ScrollBarVisibility> { ScrollBarVisibility.Auto, ScrollBarVisibility.Disabled, ScrollBarVisibility.Hidden, ScrollBarVisibility.Visible };
            TextWrappings = new List<TextWrapping> { TextWrapping.NoWrap, TextWrapping.Wrap, TextWrapping.WrapWholeWords };
            TextTrimmings = new List<TextTrimming> { TextTrimming.CharacterEllipsis, TextTrimming.Clip, TextTrimming.None, TextTrimming.WordEllipsis };
            TextAlignments = new List<TextAlignment> { TextAlignment.Center, TextAlignment.DetectFromContent, TextAlignment.Justify, TextAlignment.Left, TextAlignment.Right };
            FontWeights = new List<FontWeight>
            {
                Windows.UI.Text.FontWeights.Black,
                Windows.UI.Text.FontWeights.Bold, Windows.UI.Text.FontWeights.ExtraBlack, Windows.UI.Text.FontWeights.ExtraBold, Windows.UI.Text.FontWeights.ExtraLight, Windows.UI.Text.FontWeights.Light, Windows.UI.Text.FontWeights.Medium, Windows.UI.Text.FontWeights.Normal, Windows.UI.Text.FontWeights.SemiBold, Windows.UI.Text.FontWeights.SemiLight, Windows.UI.Text.FontWeights.Thin
            };
            FontStyles = new List<FontStyle> { FontStyle.Italic, FontStyle.Normal, FontStyle.Oblique };
        }

        public ObservableCollection<string> Actions { get; }

        public IEnumerable<ScrollMode> ScrollModes { get; }

        public IEnumerable<ScrollBarVisibility> ScrollBarVisibilities { get; }

        public IEnumerable<TextWrapping> TextWrappings { get; }

        public IEnumerable<TextTrimming> TextTrimmings { get; }

        public IEnumerable<TextAlignment> TextAlignments { get; }

        public IEnumerable<FontWeight> FontWeights { get; }

        public IEnumerable<FontStyle> FontStyles { get; }
    }
}
