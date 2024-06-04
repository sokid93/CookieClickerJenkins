using CookieClickerCode.Runtime.Domain;
using CookieClickerCode.Runtime.Presenter;
using NUnit.Framework;

namespace CookieClickerCode.Tests.EditMode
{
    public class PurchaseAutoclickerUpgradeTest
    {
        [Test]
        public void PurchaseAutoclickerUpgrade()
        {
            var cookieClicker = new CookieClicker();
            var outputCounter = new MockOutputCounter();
            cookieClicker.EarnCookie();
            var sut = new PurchaseAutoclickerUpgrade(cookieClicker, outputCounter);

            sut.Execute();

            Assert.AreEqual(1, cookieClicker.ClicksPerSecond);
        }

        [Test]
        public void DisplayRemainingCookies()
        {
            var cookieClicker = new CookieClicker();
            var outputCounter = new MockOutputCounter();
            cookieClicker.EarnCookie();
            cookieClicker.EarnCookie();
            var sut = new PurchaseAutoclickerUpgrade(cookieClicker, outputCounter);

            sut.Execute();

            Assert.AreEqual(1, outputCounter.DisplayedCookies);
        }

        [Test]
        public void CannotPurchaseAutoclickerUpgrade()
        {
            var cookieClicker = new CookieClicker();
            var outputCounter = new MockOutputCounter();
            var sut = new PurchaseAutoclickerUpgrade(cookieClicker, outputCounter);
        
            sut.Execute();
        
            Assert.AreEqual(0, cookieClicker.ClicksPerSecond);
        }
    }
}