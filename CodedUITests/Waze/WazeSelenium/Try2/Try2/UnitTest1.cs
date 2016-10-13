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
            driverGC.Navigate().GoToUrl("https://www.waze.com/");
            driverGC.FindElement(By.ClassName("tt-input")).SendKeys("Whitworth");
            //driverGC.FindElement(By.ClassName("tt-input")).SendKeys(Keys.ArrowDown);
            driverGC.FindElement(By.ClassName("leaflet-control-edit-map leaflet-control"/*tt-dataset-places*/)).Click();
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
