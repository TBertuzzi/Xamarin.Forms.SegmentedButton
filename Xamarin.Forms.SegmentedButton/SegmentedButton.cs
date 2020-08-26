using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Xamarin.Forms.SegmentedButton
{
    public class SegmentedButton
    {
        //public string Title { get; set; }

        public static readonly BindableProperty DefaultColorProperty = BindableProperty.Create("Title", typeof(string), typeof(SegmentedButton), ");

        public string Title
        {
            get { return (string)GetValue(DefaultColorProperty); }
            set { SetValue(DefaultColorProperty, value); }
        }
    }
}
