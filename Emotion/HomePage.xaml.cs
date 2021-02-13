using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Emotion
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        void Button_Round_Clicked(System.Object sender, System.EventArgs e)
        {
            if (Button_Round.Text != "On")
            {
                Navigation.PushAsync(new OptionsPage());
                Button_Round.Text = "On";
            }
            else if (Button_Round.Text == "On")
            {
                Navigation.PushAsync(new SorryToSeeYouLeavePage());
            }
        }
    }
}
