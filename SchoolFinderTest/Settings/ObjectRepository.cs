using OpenQA.Selenium;
using SchoolFinderTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFinderTest.Settings
{
    public class ObjectRepository
    {

        public static IWebDriver Driver
        {
            get; set; }

        public static IConfig Config { get; set; }

    }
}
