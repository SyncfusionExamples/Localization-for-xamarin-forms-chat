# Localization for SfChat

Localization is the process of translating application resources into different languages for specific cultures. SfChat uses the following static text that can be localized in application level:

* Today
* Type a Message

## Sample

```xaml

App.xaml.cs:

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

```

## Requirements to run the demo

To run the demo, refer to [System Requirements for Xamarin](https://help.syncfusion.com/xamarin/system-requirements).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.