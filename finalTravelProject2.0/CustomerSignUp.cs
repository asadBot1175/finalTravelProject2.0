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

    public class CustomerSignUp : CommonMethods
    {
        By SignUpBtn = By.XPath("(//a[text()='Sign Up'])[2]");
        By FirstName = By.XPath("//input[@id='inputFirstName']");
        By LastName = By.XPath("//input[@id='inputLastName']");
        By PhoneNumber = By.Id("inputPhone");
        By Email = By.XPath("//input[@name='email']");
        By CompanyName = By.Id("inputCompanyName");
        By StreetAddress = By.Id("inputAddress1");
        By StreetAddress2 = By.Id("inputAddress2");
        By  City = By.Id("inputCity");
        By  State = By.Id("stateinput");
        By  PostCode = By.Id("inputPostcode");
        By WhatsappNumber = By.Id("customfield2");
        By Password = By.XPath("//input[@placeholder='Password']");
        By ConfirmPassword = By.XPath("//input[@placeholder='Confirm Password']");
        //By RecaptchBtn = By.Id("recaptcha-anchor");

        By Register = By.XPath("//input[@type='submit']");

        public void CustomerSignUpBTN()

        {
            GetElementClick(SignUpBtn);
            switchToTab(1);
            Thread.Sleep(5000);
            //Selectdropdown(CustomerASignUp, "CustomerSignup");
            //GetElementClick(CustomerASignUp);
        }
        public void RegisterAccountWithValidCredentials()
        {
            GetElementText(FirstName, "Bruce");
            GetElementText(LastName, "Jake");
            GetElementText(Email, "brucejake1176@gmail.com");
            GetElementText(PhoneNumber, "09004567");
            GetElementText(CompanyName, " USA Motors");
            GetElementText(StreetAddress, " Liberty Chowk ");
            GetElementText(StreetAddress2, " Gulberg Gali ");
            GetElementText(City, " Chicago ");
            GetElementText(State, " USA ");
            GetElementText(PostCode, " 65433 ");
            GetElementText(WhatsappNumber, "546375482");
            GetElementText(Password, "asad12345");
            GetElementText(ConfirmPassword, "asad12345");
            Thread.Sleep(30000);
            GetElementClick(Register);

        }


    }
}
