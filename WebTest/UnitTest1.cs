using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;
using Xunit;

namespace WebTest
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            
        }

        [Fact]
        public void Test1()
        {
            Thread.Sleep(5000);

            var options = new FirefoxOptions();
            var remoteUrl = "http://selenium-firefox:4444/wd/hub";
            var driver = new RemoteWebDriver(new Uri(remoteUrl), options);

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://websut");
            Assert.Contains("Welcome", driver.PageSource);
        }
    }
}
