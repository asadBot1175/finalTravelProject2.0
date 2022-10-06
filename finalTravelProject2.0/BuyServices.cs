using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using finalTravelProject2;
using OpenQA.Selenium;
using System.Threading;

namespace finalTravelProject2
{
    public class BuyServices : CommonMethods
    {
        By OrderNewServicesBtn = By.XPath("(//a[@id='Secondary_Sidebar-Client_Shortcuts-Order_New_Services'])[1]");

        By LoginBtn = By.XPath("(//a[text()='Login'])[2]");
        By Email = By.Id("inputEmail");
        By Password = By.Id("inputPassword");
        By login = By.Id("login");
        By OrderBtn = By.Id("product1-order-button");
        By CheckoutBtn = By.Id("checkout");
        By AdditionalNotes = By.XPath("//textarea[@name='notes']");
        By CompleteOrderBtn = By.Id("btnCompleteOrder");
        By DownloadInvoice = By.XPath("//i[@class='fas fa-download']");

        public void BuyNewOrderServices()
        {
            GetElementClick(LoginBtn);
            switchToTab(1);
            Thread.Sleep(5000);
            GetElementText(Email, "brucejake11756@gmail.com");
            GetElementText(Password, "asad12345");
            Thread.Sleep(30000);
            GetElementClick(login);
            GetElementClick(OrderNewServicesBtn);
            GetElementClick(OrderBtn);
            GetElementClick(CheckoutBtn);
            GetElementText(AdditionalNotes, " Thanks for Your awesome Services");
            GetElementClick(CompleteOrderBtn);
            GetElementClick(DownloadInvoice);

        }


    }
}