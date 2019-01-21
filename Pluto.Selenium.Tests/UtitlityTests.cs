using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clbs2016.Models;

namespace Clbs2016.Tests
{
    [TestClass]
    public class UtitlityTests
    {
        [TestMethod]
        public void AutoIdTest()
        {
            Console.WriteLine(AutoId.Id);
        }
    }
}