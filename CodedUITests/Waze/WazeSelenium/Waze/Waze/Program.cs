using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Waze
{
    class Program
    {
        static void Main(string[] args)
        {
            //!Make sure to add the path to where you extracting the chromedriver.exe:
            IWebDriver driver = new ChromeDriver(@"C:\Users\mmoffett18\Desktop\chromedriver"); //<-Add your path
            driver.Navigate().GoToUrl("http://www.joecolantonio.com/HpSupport.html");
        }
    }
}
