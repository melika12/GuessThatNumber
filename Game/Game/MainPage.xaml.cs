using System;
using Xamarin.Forms;

namespace Game
{
    public partial class MainPage : ContentPage
    {
        static string val = new Random().Next(1, 100000).ToString();
        public MainPage()
        {
            InitializeComponent();
        }

        async void ButtonClicked(object sender, EventArgs e)
        {
            var checkVal = guess.Text;
            if (checkVal == val)
            {
                await DisplayAlert("Guess that number", "!!You guessed correctly!!", "Try again");
                val = new Random().Next(1, 100000).ToString();
            }
            else if (int.Parse(checkVal) < int.Parse(val))
            {
                await DisplayAlert("Guess that number", "You guessed too low", "Try again");
            }
            else if (int.Parse(checkVal) > int.Parse(val))
            {
                await DisplayAlert("Guess that number", "You guessed too high", "Try again");
            }
            else
            {
                await DisplayAlert("Guess that number", "Only use numbers!", "Try again");
            }
        }
    }
}
