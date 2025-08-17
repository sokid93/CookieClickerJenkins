using CookieClickerCode.Runtime.Domain;
using NUnit.Framework;

namespace CookieClickerCode.Tests.EditMode
{
    public class CookieClickerTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void ZeroCookiesOnStart()
        {
            CookieClicker sut = CookieClicker.CreateEmpty();
            Assert.AreEqual(0, sut.Cookies);
        }

        [Test]
        public void EarnCookie()
        {
            var sut = CookieClicker.CreateEmpty();
            sut.EarnCookie();
            Assert.AreEqual(1, sut.Cookies);
        }

        [Test]
        public void AccumulateCookies()
        {
            var sut = CookieClicker.CreateEmpty();
            sut.EarnCookie();
            sut.EarnCookie();

            Assert.AreEqual(2, sut.Cookies);
        }

        [Test]

        public void CannotSpendCookies()
        {
            var sut = CookieClicker.CreateEmpty();
        
        
            Assert.AreEqual(false, sut.CanSpendCookies(1));
        }

        [Test]
        public void CanSpendCookies()
        {
            var sut = CookieClicker.CreateEmpty();
            sut.EarnCookie();
            sut.EarnCookie();
        
        
            Assert.AreEqual(true, sut.CanSpendCookies(1));
        }
    }
}
