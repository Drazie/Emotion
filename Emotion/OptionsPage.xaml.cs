using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Emotion
{
    public partial class OptionsPage : ContentPage
    {
        public OptionsPage()
        {
            InitializeComponent();

            
        }

        public string TimeFrom { get; set; }
        public string TimeTo { get; set; }
        public int TimesPerDay { get; set; }

        void SaveOptions_Clicked(System.Object sender, System.EventArgs e)
        {
            if (timePickerfrom.Time != timePickerTo.Time)
            {
                TimeFrom = DateTime.Today.Add(timePickerfrom.Time).ToString(timePickerfrom.Format);
                TimeTo = DateTime.Today.Add(timePickerTo.Time).ToString(timePickerTo.Format);
            }
            else
            {
                DisplayAlert("Hey", "I will soon make the ability to use it 24/7, just wait a bit:)", "OK");
            }


            int TimesEntry = int.Parse(EmotionsPerDay.Text.ToString());

            if (TimesEntry != 0)
            {
                TimesPerDay = TimesEntry;
            }
            else
            {
                DisplayAlert("Whoops...", "Seems like you forgot to choose the amount of emotions a day", "Got it");
            }


            Navigation.PushAsync(new HomePage());
        }
    }
}
