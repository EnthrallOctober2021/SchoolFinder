using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SchoolFinderTest.ComponentHelper;
using System;
using TechTalk.SpecFlow;

namespace SchoolFinderTest.StepDefinitions
{
    [Binding]
    public class ShcoolSearchStepDefinitions
    {
        [Given(@"User will Launch the School Finder Web App")]
        public void GivenUserWillLaunchTheSchoolFinderWebApp()
        {
          
            GenericHelper.NavigateToUrl("");
            

        }

        [When(@"User will Search For Schools")]
        public void WhenUserWillSearchForSchools()
        {
            throw new PendingStepException();
        }

        [Then(@"User Will Select the school")]
        public void ThenUserWillSelectTheSchool()
        {
            throw new PendingStepException();
        }
    }
}
