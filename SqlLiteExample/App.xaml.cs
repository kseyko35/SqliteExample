using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SqlLiteExample
{
    public partial class App : Application
    {
        public static string DB_NAME { get; set; } = "mFirstDb.db3";
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ListPage()) ;
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
