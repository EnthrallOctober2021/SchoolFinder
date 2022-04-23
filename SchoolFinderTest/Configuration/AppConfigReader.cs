using SchoolFinderTest.Interfaces;
using SchoolFinderTest.Settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFinderTest.Configuration
{
    public class AppConfigReader : IConfig
    {



        public string GetUrl() {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Url);
                }

        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return  (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }
    }
}
