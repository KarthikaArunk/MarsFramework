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
                       
            public void Test_Share_Skill()
            {
                var shareskill = new ShareSkill();
                shareskill.EnterShareSkill();
            }

            [Test, Order(2)]

            public void Test_ViewListing()
            {
                var managelisting = new ManageListings();
                managelisting.Listings();
            }

            [Test, Order(3)]
            public void Test_DeleteListing()
            {
                var deletelisting = new ManageListings();
                deletelisting.DeleteListings();
            }

        }
    }
}