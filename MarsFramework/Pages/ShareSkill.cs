using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using MarsFramework.Global;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]

        //[FindsBy(How = How.XPath, Using = "//a[contains(text(),'Share Skill')]")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        //[FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        //private IWebElement Tags { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Storing the endtime
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input")]
        private IWebElement EndTime { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        //Enter Skill Exchange Tag
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        private IWebElement SkillExchangeTag { get; set; }

        //Select Credit
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
        private IWebElement Credit { get; set; }


        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        internal void EnterShareSkill()
        {
            //Click on  ShareSkill Button
            var wait = new WebDriverWait(Global.GlobalDefinitions.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(ShareSkillButton));
            ShareSkillButton.Click();
            
            //Enter Title
            var waittitle = new WebDriverWait(Global.GlobalDefinitions.driver, TimeSpan.FromSeconds(5));
            waittitle.Until(ExpectedConditions.ElementToBeClickable(Title));

            var titledatafromexcel = GlobalDefinitions.ExcelLib.ReadData(2,"Title");
            Title.SendKeys(titledatafromexcel);

            //Enter Description
            var descriptiondatafromexcel = GlobalDefinitions.ExcelLib.ReadData(2,"Description");
            Description.SendKeys(descriptiondatafromexcel);

            //Select Category
            var waitcategory = new WebDriverWait(Global.GlobalDefinitions.driver, TimeSpan.FromSeconds(10));
            waitcategory.Until(ExpectedConditions.ElementToBeClickable(CategoryDropDown));
            
            var categorydatafromexcel= GlobalDefinitions.ExcelLib.ReadData(2,"Category");
            CategoryDropDown.SendKeys(categorydatafromexcel);           

            //Select subcategory
            var waitsubcategory = new WebDriverWait(Global.GlobalDefinitions.driver, TimeSpan.FromSeconds(10));
            waitsubcategory.Until(ExpectedConditions.ElementToBeClickable(SubCategoryDropDown));

            var subcategorydatafromexcel = GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory");
            SubCategoryDropDown.SendKeys(subcategorydatafromexcel);
            
            //Enter Tags
            var waittags = new WebDriverWait(Global.GlobalDefinitions.driver, TimeSpan.FromSeconds(10));
            waittags.Until(ExpectedConditions.ElementToBeClickable(Tags));
                      
            var tagsdatafromexcel=GlobalDefinitions.ExcelLib.ReadData(2,"Tags");
            Tags.SendKeys(tagsdatafromexcel);
            Tags.SendKeys("\n");

            //Select ServiceType Options
            var waitservicetype = new WebDriverWait(Global.GlobalDefinitions.driver, TimeSpan.FromSeconds(10));
            waitservicetype.Until(ExpectedConditions.ElementToBeClickable(ServiceTypeOptions));
            ServiceTypeOptions.Click();

            //Select LocationType Options
            LocationTypeOption.Click();

            //Enter Startdate
            var startdatefromexcel= GlobalDefinitions.ExcelLib.ReadData(2, "Startdate");
            StartDateDropDown.SendKeys(startdatefromexcel);

            //Enter Enddate
            var enddatefromexcel = GlobalDefinitions.ExcelLib.ReadData(2, "Enddate");
            EndDateDropDown.SendKeys(enddatefromexcel);

            //Enter Days
            var daysdatafromexcel = GlobalDefinitions.ExcelLib.ReadData(2, "Selectday");
            var daycheckbox = Days.FindElement(By.XPath($"//label[text()='{daysdatafromexcel}']/preceding-sibling::input"));
            daycheckbox.Click();

            var daylabel = Days.FindElement(By.XPath($"//label[text()='{daysdatafromexcel}']"));
            var parent = daylabel.FindElement(By.XPath("./parent::div/parent::div/parent::div"));
            
            //Enter StartTime
            var starttimefromexcel = GlobalDefinitions.ExcelLib.ReadData(2, "Starttime");
            StartTime = parent.FindElement(By.Name("StartTime"));
            StartTime.SendKeys(starttimefromexcel);
           
            //Enter Endtime
            var endtimefromexcel = GlobalDefinitions.ExcelLib.ReadData(2, "Endtime");
            EndTime = parent.FindElement(By.Name("EndTime"));
            EndTime.SendKeys(endtimefromexcel);                      
           
            //Select SkillTrade
            SkillTradeOption.Click();

            //Enter SkillExchange Tag
            var skillexchangetagdatafromexcel = GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange");

            SkillExchangeTag.SendKeys(skillexchangetagdatafromexcel);
            SkillExchangeTag.SendKeys("\n");

            //Select Credit
            Credit.Click();

            //Enter Credit Amount
            var creditamountfromexcel = GlobalDefinitions.ExcelLib.ReadData(2, "CreditAmount");
            CreditAmount.SendKeys(creditamountfromexcel);

            //Select Active option
            ActiveOption.Click();

            Save.Click();
        }

        //internal void EditShareSkill()
        //{
            
        //}
    }
}
