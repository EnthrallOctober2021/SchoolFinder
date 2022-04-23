using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SchoolFinderTest.Configuration;
using SchoolFinderTest.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFinderTest.BaseClass
{
    public class BaseClass
    {


        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
;        }

        [AssemblyInitialize]
        public static void initWebDriver(TestContext tc)
        {

            ObjectRepository.Config = new AppConfigReader();

            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;
                case BrowserType.FireFox:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;


            }
        }

            [AssemblyCleanup]
            public void TearDown()
            {
            ObjectRepository.Driver.Close();
            }



        }




    }
}
