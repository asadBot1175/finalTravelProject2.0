
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Events;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace finalTravelProject2
{
    [TestClass]
    public class CommonMethods
    {
        public static readonly log4net.ILog log =

log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static IWebDriver driver;
        public static IWebDriver SetDriver(string Browser, string url)
        {
            if (Browser == "Chrome")
            {
                driver = new ChromeDriver();
            }
            else if (Browser == "FireFox")
            {
                driver = new FirefoxDriver();
            }
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            return driver;

        }
        public void GetElementActions(By By, string value)
        {

        }
        public void GetElementClick(By By)
        {
            driver.FindElement(By).Click();
            log.Info("Application is working");
        }
        public void GetElementText(By By, string Text)
        {
            IWebElement element = driver.FindElement(By);
            element.SendKeys(Text);
            log.Info("Application is working");
        }
        public void Selectdropdown(By By, string text)
        {
            IWebElement element = driver.FindElement(By);
            var selectdropdown = new SelectElement(element);
            selectdropdown.SelectByText(text);
        }
        //public void switchToTab()
        //{
        //    var prnt = driver.WindowHandles[0];
        //    var chld = driver.WindowHandles[1];
        //    driver.SwitchTo().Window(chld);
        //}
        public void switchToTab(int value)
        {

            driver.SwitchTo().Window(driver.WindowHandles[value]);
        }
    }

}