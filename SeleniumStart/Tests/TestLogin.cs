using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumStart
{
    [TestFixture]
    public class TestLogin
    {
        private IWebDriver driver = new ChromeDriver();

        [Test]
        public void testLogin()
        {
            //assign 
            GitSignIn gitSignIn = new GitSignIn(driver);
            
            //act
            LoggedInPage loggedIn = gitSignIn.LoginWithUser(TestContext.Parameters["username"], TestContext.Parameters["password"]);

            //assert
            Assert.IsTrue(driver.FindElement(loggedIn.loggedInXPath).Displayed);
            Assert.That(loggedIn.getLogInName().Contains(TestContext.Parameters["username"]));
        }
        [TearDown]
        public void Exit()
        {
            driver.Quit();
        }
    }
}
