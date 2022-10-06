using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using finalTravelProject2;
using OpenQA.Selenium;

namespace finalTravelProject2
{
    public class CustomerLogin : CommonMethods
    {

        By LoginBtn = By.XPath("(//a[text()='Login'])[2]");
        By Email = By.Id("inputEmail");
        By Password = By.Id("inputPassword");
        By login = By.Id("login");





        public void Customerlogin()
        {
            GetElementClick(LoginBtn);
            switchToTab(1);
            Thread.Sleep(5000);
            GetElementText(Email, "brucejake11756@gmail.com");
            GetElementText(Password, "asad12345");
            Thread.Sleep(30000);
            GetElementClick(login);
        }

        //public void NewOrderServices()
        //{
        //    GetElementClick(LoginBtn);
        //    switchToTab(1);
        //    Thread.Sleep(5000);
        //    GetElementText(Email, "brucejake11756@gmail.com");
        //    GetElementText(Password, "asad12345");
        //    Thread.Sleep(30000);
        //    GetElementClick(login);
        //}

    }
}
    

