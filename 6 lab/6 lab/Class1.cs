using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _6_lab
{
    [TestFixture]
    public class Class1
    {
        IWebDriver webDriver = new ChromeDriver();
        [TestCase]
        public void mainTitle()
        {
            webDriver.Url = "https://sibsutis.ru/";
            Assert.AreEqual("Сибирский государственный университет телекоммуникаций и информатики", webDriver.Title);
           
        }
       

        
        [TestCase]
        public void buttontest()
        {
            webDriver.Url = "https://sibsutis.ru/faculties/collegenbranches/";
            IWebElement button = webDriver.FindElement(By.XPath("//*[@id=\"layout\"]/div[2]/div[2]/div[1]/ul/li[3]/a"));
            button.Click();
            Assert.AreEqual("Студентам", webDriver.Title);
            
        }
        [TestCase]
        public void checktest()
        {
            webDriver.Url = "https://sibsutis.ru/";
            IWebElement search = webDriver.FindElement(By.XPath("//*[@id=\"qqq\"]"));
            search.SendKeys("Щеглов Максим");
            IWebElement button = webDriver.FindElement(By.XPath("//*[@id=\"layout\"]/div[2]/div[2]/div[2]/div[3]/form/input[2]"));
            button.Click();
            IWebElement test = webDriver.FindElement(By.XPath("//*[@id=\"system_person_14546\"]"));
            test.Click();
            Assert.AreEqual("Щеглов Максим Евгеньевич", webDriver.Title);
           
        }

        [TearDown]
        public void testend()
        {
            
        }
    }
}

