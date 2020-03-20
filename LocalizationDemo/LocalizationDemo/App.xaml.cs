using Syncfusion.XForms;
using Syncfusion.XForms.Chat;
using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SfChatDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new ChatPage();
            ChatResourceManager.Manager = new ResourceManager("LocalizationDemo.Syncfusion.SfChat.XForms", this.GetType().GetTypeInfo().Assembly);
            // the ResourceManager class constructor has two parameters.
            // 1. ResXPath => Full path of the resx file in the application. Here in the above line GettingStarted refers to the namespace of the Application
            // 2. Assembly => Application assembly (PCL)

            // Sets the required culture to the static texts in the control.
            if (Device.RuntimePlatform == Device.Android || Device.RuntimePlatform == Device.iOS)
            {
                DependencyService.Get<ILocalize>().SetLocale(new CultureInfo("fr-FR"));
            }
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
