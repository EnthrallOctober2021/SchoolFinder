using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SchoolFinderTest.Settings;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFinderTest.ComponentHelper
{
    public class GenericHelper
    {


        public static void ClickOnWebElement(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, new TimeSpan(0,0,30));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
         }

        public static void NavigateToUrl(string url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(url);
        }





    }
}
