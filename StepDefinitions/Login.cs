using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Tumblr.StepDefinitions
{
    [Binding]
    public class Login
    {
        private IWebDriver driver;

        public Login()
        {
            driver = new ChromeDriver();
        }


        [Given(@"Check login button is available in blow")]
        public void GivenCheckLoginButtonIsAvailableInBlow()
        {
            driver.Navigate().GoToUrl("https://www.tumblr.com/");
        }

        [When(@"Click On Login button")]
        public void WhenClickOnLoginButton()
        {
            driver.FindElement(By.XPath("//span[normalize-space()='Log in']")).Click();
            Thread.Sleep(6000);
        }

        [Then(@"User show the contnu with mail")]
        public void ThenUserShowTheContnuWithMail()
        {
            Assert.IsTrue(driver.Url.Contains("https://www.tumblr.com/?source=explore_floating_sign_up"));
        }

        [Then(@"Click on continu with Email button")]
        public void ThenClickOnContinuWithEmailButton()
        {
            driver.FindElement(By.XPath("//button[normalize-space()='Continue with email']")).Click();
        }

        [Then(@"Enter Email in Email text field")]
        public void ThenEnterEmailInEmailTextField()
        {
            driver.FindElement(By.XPath("//input[@placeholder='Email']")).SendKeys("raz15-4132@diu.edu.bd");
        }

        [When(@"Click on next button")]
        public void WhenClickOnNextButton()
        {
            driver.FindElement(By.XPath("//body/div[@id='root']/div[@id='base-container']/div[@id='glass-container']/div[@role='dialog']/div[@class='yKniX']/div[@class='hBHAJ tzb9e Rog1D']/div[@class='WAHT_']/div[@class='vVe9A']/div[@class='m4lSb email']/form[@method='post']/div[@class='ehOK3']/div[@class='Kz53t']/button[@aria-label='Next']/span[1]")).Click();
            Thread.Sleep(3000);
        }

        [Then(@"Input The Password in Password field")]
        public void ThenInputThePasswordInPasswordField()
        {
            driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys("Razib4144#");
        }

        [When(@"Click on Log in button")]
        public void WhenClickOnLogInButton()
        {
            driver.FindElement(By.XPath("//button[@type='submit']//span[@class='EvhBA'][normalize-space()='Log in']")).Click();
            Thread.Sleep(3000);
        }

        [Then(@"Show the Home Page is available in Display")]
        public void ThenShowTheHomePageIsAvailableInDisplay()
        {
            IWebElement homePage = driver.FindElement(By.XPath("//nav[@class='NkkDk']"));
            Assert.IsTrue(homePage.Displayed);
            Thread.Sleep(2000);
            driver.Quit();
        }

        [Given(@"Check Activity is available in site")]
        public void GivenCheckActivityIsAvailableInSite()
        {
            IWebElement Activity = driver.FindElement(By.XPath("//span[normalize-space()='Activity']"));
            Assert.IsTrue(Activity.Displayed);
            Thread.Sleep(2000);
        }

        [When(@"Click on Activity button")]
        public void WhenClickOnActivityButton()
        {
            driver.FindElement(By.XPath("//span[normalize-space()='Activity']")).Click();
        }

        [Then(@"Show the Activity Page is available in Display")]
        public void ThenShowTheActivityPageIsAvailableInDisplay()
        {
            IWebElement ActivityPage = driver.FindElement(By.XPath("//div[@role='tabpanel']"));
            Assert.IsTrue(ActivityPage.Displayed);
            Thread.Sleep(2000);
            driver.Quit();
        }


        [Given(@"Check explore is available in site")]
        public void GivenCheckExploreIsAvailableInSite()
        {
            IWebElement explore = driver.FindElement(By.XPath("//span[normalize-space()='Explore']"));
            Assert.IsTrue(explore.Displayed);
            Thread.Sleep(2000);
        }

        [When(@"Click on explore button")]
        public void WhenClickOnExploreButton()
        {
            driver.FindElement(By.XPath("//span[normalize-space()='Explore']")).Click();
            Thread.Sleep(2000);
        }

        [Then(@"Show the explore Page is available in Display")]
        public void ThenShowTheExplorePageIsAvailableInDisplay()
        {

            IWebElement explore = driver.FindElement(By.XPath("//a[@class='wl0Ka sSq2h']"));
            Assert.IsTrue(explore.Displayed);
            Thread.Sleep(2000);
            driver.Quit();
        }


        [Given(@"Check mesage is available in site")]
        public void GivenCheckMesageIsAvailableInSite()
        {
            IWebElement mesage = driver.FindElement(By.XPath("//span[normalize-space()='Messages']"));
            Assert.IsTrue(mesage.Displayed);
            Thread.Sleep(2000);
        }

        [When(@"Click on mesage button")]
        public void WhenClickOnMesageButton()
        {
            driver.FindElement(By.XPath("//span[normalize-space()='Messages']")).Click();
        }

        [Then(@"Show the mesage box is available in Display")]
        public void ThenShowTheMesageBoxIsAvailableInDisplay()
        {

            Thread.Sleep(2000);
            IWebElement inbox = driver.FindElement(By.XPath("//div[@class='DxQ0f AzqQv P4LH6']"));
            Assert.IsTrue(inbox.Displayed);
            driver.Quit();
        }

         [Given(@"Check inbox is available in site")]
        public void GivenCheckInboxIsAvailableInSite()
        {
            IWebElement mesage = driver.FindElement(By.XPath("//span[normalize-space()='Inbox']"));
            Assert.IsTrue(mesage.Displayed);
            Thread.Sleep(2000);
        }

        [When(@"Click on inbox button")]
        public void WhenClickOnInboxButton()
        {
            driver.FindElement(By.XPath("//span[normalize-space()='Inbox']")).Click();
        }

        [Then(@"Show the inbox box is available in Display")]
        public void ThenShowTheInboxBoxIsAvailableInDisplay()
        {
            IWebElement mesagebox = driver.FindElement(By.XPath("//a[normalize-space()='All Messages']"));
            Assert.IsTrue(mesagebox.Displayed);
            Thread.Sleep(2000);
            driver.Quit();
        }

        [Given(@"Check account is available in site")]
        public void GivenCheckAccountIsAvailableInSite()
        {
            IWebElement Account = driver.FindElement(By.XPath("//span[normalize-space()='Account']"));
            Assert.IsTrue(Account.Displayed);
            Thread.Sleep(2000);
        }

        [When(@"Click on account button")]
        public void WhenClickOnAccountButton()
        {
            driver.FindElement(By.XPath("//span[normalize-space()='Account']")).Click();
        }

        [Then(@"Show the account sub menu is available in Display")]
        public void ThenShowTheAccountSubMenuIsAvailableInDisplay()
        {
           

            IWebElement mesage = driver.FindElement(By.XPath(" //span[normalize-space()='Likes']"));
            Assert.IsTrue(mesage.Displayed);
            Thread.Sleep(2000);
            driver.Quit();
            
        }
       
        
        [When(@"Click on The like  button")]
        public void WhenClickOnTheLikeButton()
        {
            
            driver.FindElement(By.XPath("//span[normalize-space()='Likes']")).Click();
        }

        [Then(@"Show the like page available in display")]
         public void ThenShowTheLikePageAvailableInDisplay()
         {
            IWebElement mesage = driver.FindElement(By.XPath("//div[@class='lSyOz t8f_N']"));
            Assert.IsTrue(mesage.Displayed);
            Thread.Sleep(2000);
            driver.Quit();
         }
        

    }
}
