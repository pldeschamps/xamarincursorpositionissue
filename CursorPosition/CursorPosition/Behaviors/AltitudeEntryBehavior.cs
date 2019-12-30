using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CursorPosition.Behaviors
{
    public class AltitudeEntryBehavior : Behavior<Entry>
    {
        public static readonly BindableProperty BCursorPositionProperty =
            BindableProperty.CreateAttached("BCursorPosition", typeof(int), typeof(AltitudeEntryBehavior), 0, BindingMode.TwoWay);
        public int BCursorPosition
        {
            get { return (int)GetValue(BCursorPositionProperty); }
            set { SetValue(BCursorPositionProperty, value); }
        }
        private void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            int cp = Convert.ToInt32(BCursorPosition);
#if DEBUG
            
            System.Diagnostics.Debug.WriteLine("cursor position: " + cp);
#endif
        }
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }
        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }
    }
}
