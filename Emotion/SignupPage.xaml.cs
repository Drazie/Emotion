using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Emotion
{
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        void RegisterButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }
    }
}
