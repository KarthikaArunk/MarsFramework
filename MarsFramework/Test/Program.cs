using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Parallelizable]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test, Order(1)]
            [TestCase(2)]
            [TestCase(3)]
            [TestCase(4)]
                       
            public void Test_Share_Skill(int excelrow)
            {
                var shareskill = new ShareSkill();
                shareskill.EnterShareSkill(excelrow);
            }

            [Test, Order(2)]

            public void Test_ViewListing()
            {
                var managelisting = new ManageListings();
                managelisting.ViewListing();
            }

            [Test, Order(3)]
            public void Test_EditListing()
            {
                var managelisting = new ManageListings();
                managelisting.EditListing();
            }


            [Test, Order(4)]
            public void Test_DeleteListing()
            {
                var deletelisting = new ManageListings();
                deletelisting.DeleteListings();
            }

            [Test, Order(5)]
            [TestCase(5)]
            public void Test_AddingNewSkillFailed(int excelrow)
            {
                var addnewskillfailed = new ShareSkill();
                addnewskillfailed.AddingNewSkillFailed(excelrow);
            }

        }
    }
}