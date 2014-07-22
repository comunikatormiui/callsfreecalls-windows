using CFCforWindowsPhone.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace CFCforWindows.VM
{
    public class AppVM : BaseVM
    {
        private static AppVM _instance;

        internal static AppVM Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AppVM();
                return _instance;
            }
        }

        internal void Initialize()
        {
            InitializeResourses();
        }

        private void InitializeResourses()
        {
            foreach (var resource in LoadResourcesList())
                RegisteredResource(resource);
        }

        private void RegisteredResource(ResourceDictionary resource)
        {
            if (resource == null)
                return;

            if (!App.Current.Resources.MergedDictionaries.Contains(resource))
                App.Current.Resources.MergedDictionaries.Add(resource);
        }


        private ResourceDictionary[] LoadResourcesList()
        {
            List<ResourceDictionary> resList = new List<ResourceDictionary>();

            resList.Add(new ResourceDictionary { Source = new Uri("/CFCforWindows;component/View/LoginPageStyle.xaml", UriKind.RelativeOrAbsolute) });

            return resList.ToArray();
        }
    }
}