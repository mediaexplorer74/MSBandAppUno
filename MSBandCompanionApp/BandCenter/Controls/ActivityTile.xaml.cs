using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

//using Windows.UI.Xaml;
//using Windows.UI.Xaml.Controls;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BandCenter.Controls
{

    public sealed partial class ActivityTile : ContentView//Control
    {
        public ActivityTile()
        {
            //this.DefaultStyleKey = typeof(ActivityTile);
        }

        // RnD
        //public Type DefaultStyleKey { get; }

        void ButtonMinus_Clicked(object o, System.EventArgs e)
        {
            if (Subtitle == "")
            {
                Subtitle = "---";
            }
            else
            {
                Subtitle = "";
            }
        }

        void ButtonPlus_Clicked(object o, System.EventArgs e)
        {
            if (Subtitle == "")
            {
                Subtitle = "+++";
            }
            else
            {
                Subtitle = "";
            }
        }


        //public static readonly DependencyProperty SubtitleProperty = DependencyProperty.Register(
        //   nameof(Subtitle), typeof(string), typeof(ActivityTile), new(string.Empty));

        public static readonly BindableProperty SubtitleProperty = 
        BindableProperty.Create
        (
            "Subtitle",//nameof(Subtitle),//"IsNumeric",
            typeof(string),
            typeof(ActivityTile),
            "at",
            BindingMode.TwoWay,
            propertyChanged: P1ValueChanged//propertyChanged: NumericValueChanged
        );


        public string Subtitle
        {
            get => (string)GetValue(SubtitleProperty);
            set => SetValue(SubtitleProperty, value);
        }


        private static void P1ValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            try
            {
                //(bindable as ActivityTile).NumericLabel1.Text = Convert.ToString(newValue);
                (bindable as ActivityTile).NumericLabel1.Text = "Test";//Convert.ToString(newValue);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[ex] P1ValueChanged Exception : " + ex.Message);
            }
        }



        //public static readonly DependencyProperty MetricMarkupProperty = DependencyProperty.Register(
        //    nameof(MetricMarkup), typeof(string), typeof(ActivityTile), new(string.Empty));

        public static readonly BindableProperty MetricMarkupProperty = 
        BindableProperty.Create
        (
            "MetricMarkup",//nameof(MetricMarkup),
            typeof(string),
            typeof(ActivityTile),
            "a",//"0",
            BindingMode.TwoWay,
            propertyChanged: P2ValueChanged
        );

        public string MetricMarkup
        {
            get => (string)GetValue(MetricMarkupProperty);
            set => SetValue(MetricMarkupProperty, value);
        }

        private static void P2ValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            try
            {
                (bindable as ActivityTile).NumericLabel2.Text = Convert.ToString(newValue);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[ex] P2ValueChanged Exception : " + ex.Message);
            }
        }


        //public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
        //    nameof(Icon), typeof(IconSource), typeof(ActivityTile), new(null));
        /*
        public static readonly BindableProperty IconProperty = BindableProperty.Create
        (
           nameof(Icon),
           typeof(IconSource),
           typeof(ActivityTile),
           0.0,
           BindingMode.TwoWay,
           propertyChanged: P3ValueChanged
        );

        public IconSource Icon
        {
            get => (IconSource)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }


        private static void P3ValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as ActivityTile).NumericLabel3.Text = Convert.ToString(newValue);
        }
        */
    }

    //public class IconSource
    //{
        //
    //}
}
