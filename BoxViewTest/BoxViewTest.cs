using System;

using Xamarin.Forms;
using System.Threading;

namespace BoxViewTest
{
    public class App : Application
    {
        ContentView cv;

        BoxView bv;

        public App()
        {
            bv = new BoxView
            {
                Color = Xamarin.Forms.Color.Red,
                HeightRequest = 5,
                WidthRequest = 5,
                IsVisible = false
            };

            cv = new ContentView
            {
                Content = bv,
                IsVisible = false,
                Padding = new Thickness(10)
            };

            var btn = new Button
            {
                Text = "Click"
            };

            btn.Clicked += (sender, e) => 
            {
                cv.IsVisible = !cv.IsVisible;
                bv.IsVisible = !bv.IsVisible;
            };

            var stack = new StackLayout();
            stack.Children.Add(btn);
            stack.Children.Add(cv);

            MainPage = new ContentPage
            {
                Content = stack,
                Padding = new Thickness(15)
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

