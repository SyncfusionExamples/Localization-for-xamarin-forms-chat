using SfChatDemo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(SfChatDemo.UWP.Localize))]
namespace SfChatDemo.UWP
{
    public class Localize : ILocalizeUWP
    {
        public void SetLocale(CultureInfo cultureInfo)
        {
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }
    }
}
