﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SfChatDemo
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();
        void SetLocale(CultureInfo cultureInfo);
    }
    public class PlatformCulture
    {
        public PlatformCulture(string platformCultureString)
        {
            if (String.IsNullOrEmpty(platformCultureString))
                throw new ArgumentException("Expected culture identifier", "platformCultureString"); // in C# 6 use NameOf(platformCultureString)

            PlatformString = platformCultureString.Replace("_", "-"); // .NET expects dash, not underscore
            var dashIndex = PlatformString.IndexOf("-", StringComparison.Ordinal);
            if (dashIndex > 0)
            {
                var parts = PlatformString.Split('-');
                LanguageCode = parts[0];
                LocaleCode = parts[1];
            }
            else
            {
                LanguageCode = PlatformString;
                LocaleCode = "";
            }
        }

        public string PlatformString
        {
            get; private set;
        }

        public string LanguageCode
        {
            get; private set;
        }

        public string LocaleCode
        {
            get; private set;
        }

        public override string ToString()
        {
            return PlatformString; ;
        }
    }

    public interface ILocalizeUWP
    {
        void SetLocale(CultureInfo cultureInfo);
    }
}