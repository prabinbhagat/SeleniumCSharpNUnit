using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumCSharp.BaseClass;

namespace SeleniumCSharp
{
    [TestFixture]   // this attribute is used for representation of classes
    public class Tests:BaseTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]      // Multiple test cases to represnt any test case we will use TEST attribute
        public void Test1()
        {
            //IWebDriver driver = new ChromeDriver(); //creating an object of chrome driver and then assign into interface called iwebdriver
            //driver.Url = "https://www.facebook.com";
            // the above first line will open the chrome and second line will enter the url
            IWebElement fbEmailText = driver.FindElement(By.XPath(".//*[@id='email']"));  // find element assign it to iwebelement interface
            fbEmailText.SendKeys("prabinbhagat@yahoo.in"); // sending value in the text email field

            IWebElement fbPassText = driver.FindElement(By.XPath(".//*[@id='pass']"));
            fbPassText.SendKeys("Baba@123");
                       
            IWebElement loginBtn = driver.FindElement(By.Name("login"));
            //loginBtn.Click();
            //driver.Quit(); // close the webbrowser  
            //Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            IWebElement fbEmailText = driver.FindElement(By.XPath(".//*[@id='email']"));
            fbEmailText.Clear();
            Thread.Sleep(5000);
            fbEmailText.SendKeys("prabinbhagat@gmail.com");
            Thread.Sleep(5000);
        }
    }
}