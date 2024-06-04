using CookieClickerCode.Runtime.Domain;
using CookieClickerCode.Runtime.Presenter;
using NUnit.Framework;

namespace CookieClickerCode.Tests.EditMode
{
    public class PurchaseCookiesX2UpgradeTest
    {
        [Test]
        public void PurchaseCookiesX2Upgrade()
        {
            var cookieClicker = new CookieClicker();
            var outputCounter = new MockOutputCounter();
            cookieClicker.EarnCookie();
            var sut = new PurchaseCookiesX2Upgrade(cookieClicker, outputCounter);

            sut.Execute();

            Assert.AreEqual(2, cookieClicker.CookiesMultiplier);
            Assert.AreEqual(0, cookieClicker.Cookies);
        }

        [Test]
        public void DisplayRemainingCookies()
        {
            var cookieClicker = new CookieClicker();
            var outputCounter = new MockOutputCounter();
            cookieClicker.EarnCookie();
            cookieClicker.EarnCookie();
            var sut = new PurchaseCookiesX2Upgrade(cookieClicker, outputCounter);

            sut.Execute();

            Assert.AreEqual(1, outputCounter.DisplayedCookies);
        }

        [Test]
        public void CannotPurchaseCookiesX2Upgrade()
        {
            var cookieClicker = new CookieClicker();
            var outputCounter = new MockOutputCounter();
            var sut = new PurchaseCookiesX2Upgrade(cookieClicker, outputCounter);
        
            sut.Execute();
        
            Assert.AreEqual(0, outputCounter.DisplayedCookies);
            Assert.AreEqual(1, cookieClicker.CookiesMultiplier);
        }
    }
}
