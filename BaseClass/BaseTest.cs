using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharp.BaseClass
{

    public class BaseTest
    {
        // Here we will setup one time setup and one time teardown attribute
        // Basically when we have 50 test scripts this two method will run one time before running
        // all 50 test onetimesetup attribute will work and after running all test onetimeteardownwill work
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com";
        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }


    }
}
