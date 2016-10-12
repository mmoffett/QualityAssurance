using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace seleniumDemo
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driverGC;
        //static IWebDriver driverFF;

        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            //driverFF = new FirefoxDriver();
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized");
            driverGC = new ChromeDriver(options);


        }
        [TestMethod]
        public void TestChromeDriver()
        {
            driverGC.Navigate().GoToUrl("https://www.waze.com/livemap");
            IWebElement el = driverGC.FindElement(By.ClassName("twitter-typeahead"));
            el.Click();
         el.Clear();
            el.SendKeys("Hi");
          //driverGC.FindElement(By.ClassName("twitter-typeahead")).Click();//SendKeys("Whitworth");
          //driverGC.type("twitter-typeahead","Whitworth");
            //driverGC.
           // driverGC.FindElement(By.LinkText("Search for an address or place")); //.SendKeys("Whitworth");
            //driverGC.FindElement(By.ClassName("gsfi")).SendKeys("Selenium");
           // driverGC.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
        }


       //[TestMethod]
       // public void TestFFDriver()
       //{
       //      driverFF.Navigate().GoToUrl("http://www.google.com");
       //      driverFF.FindElement(By.Id("lst-ib")).SendKeys("Selenium");
       //      driverFF.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
       //}
    }
}
