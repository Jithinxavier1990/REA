using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REA.Modules.Legal
{
    [TestClass]
    public class REA_List
    {
        readonly IWebDriver driver = new ChromeDriver();

        [NUnit.Framework.SetUp]
        public void Setup()
        {
            //IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");

        }

        [NUnit.Framework.TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [TestMethod]
        public void VacantList()
        {
            // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("mat-input-0")).SendKeys("vijay.gopal@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Units");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[text()='   Filter']")).Click();
            System.Threading.Thread.Sleep(1000);



            var StatusVacant = driver.FindElement(By.XPath("//mat-sidenav-container[@id='sidenavContainer']/mat-sidenav-content[1]/div[3]/app-unit-list[1]/div[1]/div[2]/div[4]/div[1]/div[1]/select[1]"));
            var StatusFilterselectElement = new SelectElement(StatusVacant);
            StatusFilterselectElement.SelectByValue("5");
            System.Threading.Thread.Sleep(2000);

           // driver.FindElement(By.XPath("mat - select - value - 1")).Click();
            driver.FindElement(By.XPath("//mat-form-field[contains(@class,'mat-mdc-form-field mat-mdc-paginator-page-size-select')]//div")).Click();
            //driver.FindElement(By.XPath("//mat-sidenav-container[@id='sidenavContainer']/mat-sidenav-content[1]/div[3]/app-unit-list[1]/div[1]/div[2]/div[4]/div[1]/div[1]/select[1]")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//mat-option[@ng-reflect-value='100']")).Click();


        }

        [TestMethod]
        public void ContractGoingToExpire()
        {
            // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("mat-input-0")).SendKeys("vijay.gopal@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/TenancyContract");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[text()='   Filter ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(@class,'mat-mdc-select-value-text ng-tns-c3393473648-12')]//span[1]")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//mat-option[@ng-reflect-value='3']//mat-pseudo-checkbox[1]")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//mat-option[@ng-reflect-value='4']//mat-pseudo-checkbox[1]")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//mat-option[@ng-reflect-value='11']//mat-pseudo-checkbox[1]")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//mat-option[@ng-reflect-value='15']//mat-pseudo-checkbox[1]")).Click();
           // System.Threading.Thread.Sleep(2000);
          //  driver.FindElement(By.XPath("//mat-option[@id='mat-option-13']//mat-pseudo-checkbox[1]")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//mat-option[@ng-reflect-value='16']//mat-pseudo-checkbox[1]")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='cdk-overlay-container']//div")).Click();
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("//mat-form-field[contains(@class,'mat-mdc-form-field mat-mdc-paginator-page-size-select')]//div")).Click();
          
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//mat-option[@ng-reflect-value='100']")).Click();


        }

        [TestMethod]
        public void ContractGoingToExpire_Mae()
        {
            // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("mat-input-0")).SendKeys("mae.salvador@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/TenancyContract");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[text()='   Filter ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(@class,'mat-mdc-select-value-text ng-tns-c3393473648-12')]//span[1]")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//mat-option[@ng-reflect-value='3']//mat-pseudo-checkbox[1]")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//mat-option[@ng-reflect-value='4']//mat-pseudo-checkbox[1]")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//mat-option[@ng-reflect-value='11']//mat-pseudo-checkbox[1]")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//mat-option[@ng-reflect-value='15']//mat-pseudo-checkbox[1]")).Click();
            // System.Threading.Thread.Sleep(2000);
            //  driver.FindElement(By.XPath("//mat-option[@id='mat-option-13']//mat-pseudo-checkbox[1]")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//mat-option[@ng-reflect-value='16']//mat-pseudo-checkbox[1]")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='cdk-overlay-container']//div")).Click();
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("//mat-form-field[contains(@class,'mat-mdc-form-field mat-mdc-paginator-page-size-select')]//div")).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//mat-option[@ng-reflect-value='100']")).Click();


        }

    }


    }

