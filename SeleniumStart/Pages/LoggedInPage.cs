using OpenQA.Selenium;

namespace SeleniumStart
{
    public class LoggedInPage
    {
        private IWebDriver webDriver;
        public By loggedInXPath = By.XPath("//summary/img");
        
        public LoggedInPage(IWebDriver driver)
        {
            webDriver = driver;
        }

        public string getLogInName()
        {
            return webDriver.FindElement(loggedInXPath).GetAttribute("alt");
        }

        public bool isHeaderDisplayed()
        {
            return webDriver.FindElement(By.XPath("//html/body/div[1]")).Displayed;
        }
        
        
    }
}
