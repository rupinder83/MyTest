using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace GBProject
{
    public class GBPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("http://www.globalblue.com/customer-services/tax-free-shopping/refund-calculator/");
           // var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            //wait.Until((d => d.SwitchTo().ActiveElement().GetAttribute("ClassName") == "refundAmount"));
        }

        public static void PurchaseCountry()
        {
            var purchaseCountryDropDown = Driver.Instance.FindElement(By.Name("jurisdictions"));
            purchaseCountryDropDown.SendKeys("AUT");
        }

        public static void PurchaseAmount(string purchaseAmountValue)
        {
            var purchaseAmountInput = Driver.Instance.FindElement(By.Name("refundInput"));
            purchaseAmountInput.SendKeys(purchaseAmountValue);
        }

        public static void Calculate()
        {
            var calculateInput = Driver.Instance.FindElement(By.Name("submitRefund"));
            calculateInput.Submit();
        }

        public static string RefundAmount()
        {
            var refundAmount = Driver.Instance.FindElement(By.ClassName("refundAmount"));
            return refundAmount.Text;
        }

        public static string InvalidMessage()
        {
            var invalidMessage = Driver.Instance.FindElement(By.ClassName("message"));
            return invalidMessage.Text;
        }

        public static void AppendRefund()
        {
            var appendRefund = Driver.Instance.FindElement((By.ClassName("appendRefund")));
            appendRefund.Click();
        }

        public static string TotalRefundAmount()
        {
            var totalRefundAmount = Driver.Instance.FindElement(By.CssSelector(".refund.tblue"));
            return totalRefundAmount.Text;
        }
    }
}
