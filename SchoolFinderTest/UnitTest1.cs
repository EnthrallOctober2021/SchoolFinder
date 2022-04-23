using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SchoolFinderTest
{
    [TestClass]
    public class UnitTest1
    {
        
       
        [TestMethod]
        
        public void TestMethod1()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://louisianaschools.com/");
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
            Driver.FindElement(By.XPath("//input[@placeholder='Enter Name or Address']")).Click();
            Driver.FindElement(By.XPath("//input[@placeholder='Enter Name or Address']")).SendKeys("Lycee");
            Thread.Sleep(4000);
            IList<IWebElement> SelectSchool = Driver.FindElements(By.XPath("//div[@id='wide-div']//div[@class='col'][1]//h6[1]/following-sibling::a"));
            for (int i = 0; i < SelectSchool.Count; i++)
            {
                SelectSchool[2].Click();

            }
            Thread.Sleep(4000);
            Driver.FindElement(By.Id("searchButton")).Click();
            Thread.Sleep(4000);
        }

        
        /*

        public IWebElement FirstSchool(int SNo) {
            Console.WriteLine("Schools Number: " + SelectSchool.Count);
            for (int i=0;i<SelectSchool.Count; i++) {
               var S = SelectSchool[SNo];
                
            }
            return SelectSchool[SNo];
         }

        */

    }
}
