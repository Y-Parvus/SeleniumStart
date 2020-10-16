using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumStart
{
    public class TestMainPage
    {
        private IWebDriver driver = new ChromeDriver();
        public GitSignIn Login()
        {
            GitSignIn gitSignIn = new GitSignIn(driver);
            return gitSignIn;
        }

        [Test]
        public void testMainPage()
        {
            //login
            LoggedInPage loggedIn = Login().LoginWithUser(TestContext.Parameters["username"], TestContext.Parameters["password"]); 

            Assert.IsTrue(loggedIn.isHeaderDisplayed());
        }

        [TearDown]
        public void Exit()
        {
            driver.Quit();
        }
    }
}
