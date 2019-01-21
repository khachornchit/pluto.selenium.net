using Clbs2016.Models;
using Clbs2016.Models.NewDesigned;
using Clbs2016.Process;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumUtilities;
using System;

namespace Clbs2016.Tests
{
    [TestClass]
    public class InteressentMandatoryTest
    {
        [TestInitialize]
        public void DefineDefaultBrowser()
        {
            PropertiesCollection.SetDefaultBrowserChrome();
        }

        [TestMethod]
        public void InteressentProcessTestTop()
        {
            Console.WriteLine(string.Format("{0} Interessent Process Test Top Elements", WorkAndStudy.Name));
            PropertiesCollection.OpenBrowser(WorkAndStudy.Url);
            WorkAndStudy page = new WorkAndStudy();
            if (page.InteressentMandatoryFill()) { };
            foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void InteressentProcessTestBottom()
        {
            Console.WriteLine(string.Format("{0} Interessent Process Test Bottom Elements", WorkAndStudy.Name));
            PropertiesCollection.OpenBrowser(WorkAndStudy.Url);
            WorkAndStudy page = new WorkAndStudy();
            if (page.InteressentMandatoryFillBottom()) { };
            foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }
    }
}