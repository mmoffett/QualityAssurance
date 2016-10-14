using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;

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
            driverGC.FindElement(By.ClassName("tt-input")).SendKeys("Whitworth");
            var el = driverGC.FindElements(By.XPath("//*[@id = 'origin'] / div / span / span / div"));
            Actions act = new Actions(driverGC).MoveToElement(el, 0, 0).movebyOffSet(20, 20).Click().build().perform();


            //driverGC.FindElement(By.XPath("//*[@id = 'origin'] / div / span / span / div")).MoveToOffsetAction(20,20).Click(); //ClassName("tt-dataset-places"));
        }

        /*     [TestMethod]
               public void TestGCDriver2()
              {
                    driverGC.Navigate().GoToUrl("http://www.google.com");
                    driverGC.FindElement(By.Id("lst-ib")).SendKeys("Selenium");
                    driverGC.FindElement(By.ClassName("sbqs_c.gsfs")).Click();//SendKeys(Keys.ArrowDown);
              }
        */

        //[TestMethod]
        // public void TestFFDriver()
        //{
        //      driverFF.Navigate().GoToUrl("http://www.google.com");
        //      driverFF.FindElement(By.Id("lst-ib")).SendKeys("Selenium");
        //      driverFF.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
        //}
    }
}
