using MedMeter.Services;
using MedMeter.Views;
using Xamarin.Forms;

namespace MedMeter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MedicineImageService.Init();

            MainPage = new NavigationPage(new MainPage());
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
