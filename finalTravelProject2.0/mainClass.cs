
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
using finalTravelProject2;

namespace finalTravelProject2
{
    [TestClass]
    public class TestExecution
    {
        [TestClass]
        public class UnitTest1
        {

            [AssemblyInitialize]
            public static void AssemblyInitialize(TestContext context)
            {

            }
            [AssemblyCleanup]
            public static void AssemblyCleanup()
            {

            }
            [ClassInitialize]
            public static void ClassInitialize(TestContext context)
            {
                CommonMethods.SetDriver("Chrome", "https://phptravels.com/");
            }
            [ClassCleanup]
            public static void ClassCleanup()
            {

            }
            [TestInitialize]
            public void TestInitialize()
            {

            }
            [TestCleanup]
            public void TestCleanup()
            {

            }
            CustomerSignUp ob = new CustomerSignUp();
            CustomerLogin login = new CustomerLogin();
            BuyServices buyServices = new BuyServices();



            [TestMethod]

            public void CustomerSignUp()
            {
                ob.CustomerSignUpBTN();
                ob.RegisterAccountWithValidCredentials();

            }

            [TestMethod]
            public void CustomerLogin()
            {

                login.Customerlogin();

            }

            [TestMethod]
            public void BuyServices()
            {
                buyServices.BuyNewOrderServices();
            }



        }
    }
}
