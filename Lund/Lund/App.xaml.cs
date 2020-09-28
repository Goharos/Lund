using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lund
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Lund1();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
