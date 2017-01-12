using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234235

namespace UwpControlsDemo
{
    public sealed class SampleBroswerItem : ContentControl
    {
        public SampleBroswerItem()
        {
            this.DefaultStyleKey = typeof(SampleBroswerItem);
        }

                /// <summary>
        /// 获取或设置PropertiesContent的值
        /// </summary>  
        public object PropertiesContent
        {
            get { return (object)GetValue(PropertiesContentProperty); }
            set { SetValue(PropertiesContentProperty, value); }
        }

        /// <summary>
        /// 标识 PropertiesContent 依赖属性。
        /// </summary>
        public static readonly DependencyProperty PropertiesContentProperty =
            DependencyProperty.Register("PropertiesContent", typeof(object), typeof(SampleBroswerItem), new PropertyMetadata(null));

       
    }
}
