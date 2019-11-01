using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ChromeOptions = new ChromeOptions();
            ChromeOptions.AddArgument("headless");
            IWebDriver driver = new ChromeDriver(ChromeOptions);
            //IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https: //www.demoqa.com/");
            string Title = driver.Title;
            int TitleLength = driver.Title.Length;
            Console.WriteLine("Title of the page is :" + Title);

            Console.WriteLine("Length of the page is :" + TitleLength);
            String pageUrl = driver.Url;
            int urlLength = pageUrl.Length;
            Console.WriteLine("url of the page is :" + pageUrl);

            Console.WriteLine("url Length is :" + urlLength);
            string pageSourse = driver.PageSource;
            int pageSourseLength = driver.PageSource.Length;
            Console.WriteLine("url pageSourse is :" + pageSourse);
            Console.WriteLine("Lenght of the page souse is  is :" + pageSourseLength);
            driver.Quit();

            //driver.FindElement(By.Name("q")).SendKeys("Selenium Web Driver");

            ////driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Jamboard'])[1]/following::div[9]")).Click();
            //drive

            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.google.com/");
            //driver.FindElement(By.Name("q")).SendKeys("Selenium Web Driver");

            ////driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Jamboard'])[1]/following::div[9]")).Click();
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Eliminar'])[11]/following::input[3]")).Click();
            //driver.FindElement(By.Name("btnK")).Click();
            // driver.Close();
            //driver.FindElement(By.Id("q")).SendKeys("ricardo4013@gmail.com");

            //int a =10;
            //int b =20;
            //int resultadoEspeado = 30;
            //int resutaldoReal;
            //resutaldoReal = a + b;
            //Assert.AreEqual(resultadoEspeado, resutaldoReal);
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.google.com/");

            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            //driver.FindElement(By.LinkText("Contact us")).Click();
            //driver.FindElement(By.Id("id_contact")).Click();
            //new SelectElement(driver.FindElement(By.Id("id_contact"))).SelectByText("Webmaster");
            //driver.FindElement(By.Id("id_contact")).Click();
            //driver.FindElement(By.Id("email")).Click();
            //driver.FindElement(By.Id("email")).Clear();
            //driver.FindElement(By.Id("email")).SendKeys("ricardo4013@gmail.com");
            //driver.FindElement(By.Id("id_order")).Click();
            //driver.FindElement(By.Id("id_order")).Clear();
            //driver.FindElement(By.Id("id_order")).SendKeys("Error en pedido");
            //driver.FindElement(By.Id("message")).Click();
            //driver.FindElement(By.Id("message")).Clear();
            //driver.FindElement(By.Id("message")).SendKeys("Error");
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Message'])[1]/following::span[1]")).Click();
            //Assert.AreEqual("Your message has been successfully sent to our team.", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Customer service - Contact us'])[1]/following::p[1]")).Text);


        }
    }
}
