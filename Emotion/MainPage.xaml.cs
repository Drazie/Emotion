using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Emotion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void SignupButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SignupPage());
        }

        void LoginButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }
    }
}
