﻿using System;
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
    public sealed class SampleBrowser : ContentControl
    {
        public SampleBrowser()
        {
            this.DefaultStyleKey = typeof(SampleBrowser);
        }

        /// <summary>
        /// 获取或设置Header的值
        /// </summary>  
        public object Header
        {
            get { return (object)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        /// <summary>
        /// 标识 Header 依赖属性。
        /// </summary>
        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(object), typeof(SampleBrowser), new PropertyMetadata(null));

        /// <summary>
        /// 获取或设置Information的值
        /// </summary>  
        public object Information
        {
            get { return (object)GetValue(InformationProperty); }
            set { SetValue(InformationProperty, value); }
        }

        /// <summary>
        /// 标识 Information 依赖属性。
        /// </summary>
        public static readonly DependencyProperty InformationProperty =
            DependencyProperty.Register("Information", typeof(object), typeof(SampleBrowser), new PropertyMetadata(null));

    }
}