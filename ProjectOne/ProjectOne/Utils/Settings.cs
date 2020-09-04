using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.Utils
{
    public static class Settings
    {
        //private static ISettings AppSettings
        //{
        //    get
        //    {
        //        return CrossSettings.Current;
        //    }
        //}

        private static ISettings AppSettings =>
         CrossSettings.Current;


        #region Setting Constants

        //private const string SettingsKey = "settings_key";
        //private static readonly string SettingsDefault = string.Empty;

        #endregion

        //public static string GeneralSettings
        //{
        //    get
        //    {
        //        return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
        //    }
        //    set
        //    {
        //        AppSettings.AddOrUpdateValue(SettingsKey, value);
        //    }
        //}

      
        //public static string GeneralSettings
        //{
        //    get => AppSettings.GetValueOrDefault(nameof(GeneralSettings), string.Empty);
        //    set => AppSettings.AddOrUpdateValue(nameof(GeneralSettings), value);
        //}


        
          public static string FirstName
        {
            get => AppSettings.GetValueOrDefault(nameof(FirstName), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(FirstName), value);
        }

        public static string Surname
        {
            get => AppSettings.GetValueOrDefault(nameof(Surname), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Surname), value);
        }
        public static string Email
        {
            get => AppSettings.GetValueOrDefault(nameof(Email), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Email), value);
        }
          public static string Address
        {
            get => AppSettings.GetValueOrDefault(nameof(Address), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Address), value);
        }
          public static string MobileNumber
        {
            get => AppSettings.GetValueOrDefault(nameof(MobileNumber), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(MobileNumber), value);
        }
          public static string Password
        {
            get => AppSettings.GetValueOrDefault(nameof(Password), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Password), value);
        }


        // normal way  
//        private const string Password = "password";
//        private static readonly string PasswordDefault = string.Empty;
//#endregion

//        public static string PasswordSettings
//        {
//            get
//            {
//                return AppSettings.GetValueOrDefault(Password, PasswordDefault);
//            }
//            set
//            {
//                AppSettings.AddOrUpdateValue(Password, value);
//            }
//        }

        public static string ConfrimPassword
        {
            get => AppSettings.GetValueOrDefault(nameof(ConfrimPassword), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(ConfrimPassword), value);
        }
          public static string Avatar
        {
            get => AppSettings.GetValueOrDefault(nameof(Avatar), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Avatar), value);
        }

        public static void ClearEverything()
        {
            AppSettings.Clear();
        }

    }
}
