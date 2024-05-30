using System;
using CookieClickerCode.Runtime.Domain;
using CookieClickerCode.Runtime.Presenter;
using NUnit.Framework;

namespace CookieClickerCode.Tests.EditMode
{
    public class EarnCookiesByTimeTests
    {
        
        [Test]
        public void NotEarnsCookies()
        {
            var cookieClicker = CookieClicker.CreateEmpty();
            var outputCounter = new MockOutputCounter();
            var earnCookiePresenter = new EarnCookie(cookieClicker, outputCounter);
            var sut = new EarnCookiesByTime(earnCookiePresenter);

            sut.Execute(new DateTime());

            Assert.AreEqual(0, cookieClicker.Cookies);
        }

        [Test]
        public void EarnACookieInASecond()
        {
            var cookieClicker = CookieClicker.CreateEmpty();
            var outputCounter = new MockOutputCounter();
            var earnCookiePresenter = new EarnCookie(cookieClicker, outputCounter);
            var sut = new EarnCookiesByTime(earnCookiePresenter);
            cookieClicker.ClicksPerSecond = 1;
            
            sut.Execute(new DateTime());
            sut.Execute(new DateTime() + TimeSpan.FromSeconds(1));
            
            Assert.AreEqual(1, cookieClicker.Cookies);
        }
    }

    public class EarnCookiesByTime
    {
        private readonly EarnCookie earnCookiePresenter;

        public EarnCookiesByTime(EarnCookie earnCookiePresenter)
        {
            this.earnCookiePresenter = earnCookiePresenter;
        }

        public void Execute(DateTime dateTime)
        {
            
        }
    }
}