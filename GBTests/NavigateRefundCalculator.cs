using System;
using GBProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
    

namespace GBTests
{
    [TestClass]
    public class NavigateRefundCalculator : InitializeCleanup
    {
        
        [TestMethod]
        //Successful calculation of tax refund for single purchase.
        public void CheckRefundCalculation()
        {
            GBPage.GoTo();
            GBPage.PurchaseCountry();
            GBPage.PurchaseAmount("250");
            GBPage.Calculate();
            Assert.IsTrue(GBPage.RefundAmount() == "28.50", "Refund amount is not as expected");
            GBPage.AppendRefund();
            Assert.IsTrue(GBPage.TotalRefundAmount() == "28.50", "Total refund amount is not as expected");
        }
       

        [TestMethod]
        //Empty Purchase Amount
        public void NoPurchaseAmount()
        {
            GBPage.GoTo();
            GBPage.PurchaseCountry();
            GBPage.Calculate();
            GBPage.InvalidMessage();
            Assert.IsTrue(GBPage.InvalidMessage() == "Your input is not a valid number. Please try again.");
        }

        [TestMethod]
        //Shows error message when the purchase amount is less than the specified limit for tax refund.
        public void LowPurchaseAmount()
        {
            GBPage.GoTo();
            GBPage.PurchaseCountry();
            GBPage.PurchaseAmount("50");
            GBPage.Calculate();
            Assert.IsTrue(GBPage.InvalidMessage() == "You will need to spend at least EUR75.01 to qualify for a tax refund.");
        }
       
    }
}

