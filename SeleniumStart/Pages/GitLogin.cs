using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumStart
{
    public class GitSignIn
    {
        private IWebDriver webDriver;

        private string url = TestContext.Parameters["webAppLoginUrl"];
        private By usernameBy = By.Name("login");
        private By passwordBy = By.Name("password");
        private By logInBy = By.Name("commit");

        
        public GitSignIn(IWebDriver driver)
        {
            webDriver = driver;
            driver.Navigate().GoToUrl(url);
        }

        public LoggedInPage LoginWithUser(string username, string password)
        {
            webDriver.Navigate().GoToUrl(url);
            webDriver.FindElement(usernameBy).SendKeys(username);
            webDriver.FindElement(passwordBy).SendKeys(password);
            webDriver.FindElement(logInBy).Click();
            return new LoggedInPage(webDriver);

        }

    }
}