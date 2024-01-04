﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UI_Tests
{
    public class OnboardPage
    {
        IWebDriver driver;
        public OnboardPage(IWebDriver driver)
        {
            this.driver = driver;
            #region InitElements: Open to Read
            //PageFactory.InitElements(driver, this);
            //use this for elements with [FindsBy()] method which would not require "driver.FindElement" to be written for each element instead the elements will be initialized when the constructor is called
            #endregion
        }
        public By On_Board = By.XPath("//a[@href='/app/onboard-candidates/']");
        public By First_Name = By.XPath("//label[contains(text(),'First Name')]/following-sibling::div/input[@type='text']");
        public By Last_Name = By.XPath("//label[contains(text(),'Last Name')]/following-sibling::div/input[@type='text']");
        public By Email_id = By.XPath("//label[contains(.,'Email ID*')]/following-sibling::div/input[@type='text']");
        public By Phone_Number = By.XPath("//label[contains(.,'Phone Number')]/following-sibling::div/input[@type]");
        public By Gender = By.XPath("//label[contains(.,'Male')]");
        public By Employment_type = By.XPath("//label[contains(.,'Employment Type')]/following-sibling::div/select");
        public By Tax_Terms = By.XPath("//label[contains(.,'Tax Terms')]/following-sibling::div/select");
        public By Current_Work_Type = By.XPath("//label[contains(.,'Current Work Authorization Type')]/following-sibling::div/select");

    }
}
