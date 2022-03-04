using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System;
using NUnit.Framework;

namespace MarsFramework.Pages
{
    
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link

        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        //[FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        //private IWebElement view { get; set; }

        //View the listing

        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        //[FindsBy(How = How.XPath, Using = "//table[1]/tbody[1]")]
        //private IWebElement delete { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i")]
        private IWebElement delete { get; set; }

        //Edit the listing
        //[FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        //private IWebElement edit { get; set; }

        //Edit the listing
        //[FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i")]
        //private IWebElement edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        //Storing the table of listings
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table")]
        private IWebElement ListingTable { get; set; }

        internal void Listings()
        {
            //Populate the Excel Sheet
            //GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");

            var waitmanagelist = new WebDriverWait(Global.GlobalDefinitions.driver, TimeSpan.FromSeconds(10));
            waitmanagelist.Until(ExpectedConditions.ElementToBeClickable(manageListingsLink));
            
            manageListingsLink.Click();

            var waitview = new WebDriverWait(Global.GlobalDefinitions.driver, TimeSpan.FromSeconds(5));
            waitview.Until(ExpectedConditions.ElementToBeClickable(view));

            view.Click();
        }

        internal void DeleteListings()
        {
            //Populate the Excel Sheet
            //GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "DeleteSkill");

            var waitmanagelist = new WebDriverWait(Global.GlobalDefinitions.driver, TimeSpan.FromSeconds(10));
            waitmanagelist.Until(ExpectedConditions.ElementToBeClickable(manageListingsLink));

            manageListingsLink.Click();

            var waitdelete = new WebDriverWait(Global.GlobalDefinitions.driver, TimeSpan.FromSeconds(6));
            waitdelete.Until(ExpectedConditions.ElementToBeClickable(delete));

            var skilltodeletefromexcel = GlobalDefinitions.ExcelLib.ReadData(2, "Title");
            var tablerow = ListingTable.FindElement(By.XPath($"//td[text()='{skilltodeletefromexcel}']/parent::tr"));
            var deletebutton = tablerow.FindElement(By.XPath($"//td[8]//button[3]"));
                        
            deletebutton.Click();
            var yesbutton = clickActionsButton.FindElement(By.CssSelector(".positive"));
            yesbutton.Click();
            
        }
    }
}
