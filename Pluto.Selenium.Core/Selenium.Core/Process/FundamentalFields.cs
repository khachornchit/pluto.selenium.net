using SeleniumCore.Models;
using System.Collections.Generic;

namespace SeleniumCore.Process
{
    public class FundamentalFields
    {
        public string Name { get; set; }
        public List<TestResultInPage> TestResultInPages { get; set; }
        private string TestName { get; set; }
        public static string Url { get; set; }
    } 
}