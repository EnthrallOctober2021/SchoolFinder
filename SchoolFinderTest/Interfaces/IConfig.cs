using SchoolFinderTest.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFinderTest.Interfaces
{
    public interface IConfig
    {
        string GetUrl();
        BrowserType GetBrowser();


    }
}
