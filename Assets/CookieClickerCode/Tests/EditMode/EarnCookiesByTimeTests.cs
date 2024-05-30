using System;
using CookieClickerCode.Runtime.Domain;
using CookieClickerCode.Runtime.Presenter;
using NUnit.Framework;

namespace CookieClickerCode.Tests.EditMode
{
    public class EarnCookiesByTimeTests
    {
        private static void CreateSUT(out EarnCookiesByTime sut, out CookieClicker cookieClicker)
        {
            cookieClicker = CookieClicker.CreateEmpty();
            var outputCounter = new MockOutputCounter();
            var earnCookiePresenter = new EarnCookie(cookieClicker, outputCounter);
            sut = new EarnCookiesByTime(earnCookiePresenter);
        }
        
        [Test]
        public void NotEarnsCookies()
        {
            CreateSUT(out var sut, out var cookieClicker);

            sut.Execute(new DateTime());

            Assert.AreEqual(0, cookieClicker.Cookies);
        }

        [Test]
        public void EarnACookieInASecond()
        {
            CreateSUT(out var sut, out var cookieClicker);
            cookieClicker.ClicksPerSecond = 1;
            
            sut.Execute(new DateTime());
            sut.Execute(new DateTime() + TimeSpan.FromSeconds(1));
            
            Assert.AreEqual(1, cookieClicker.Cookies);
        }

        [Test]
        public void AccumulateTime()
        {
            CreateSUT(out var sut, out var cookieClicker);
            cookieClicker.ClicksPerSecond = 1;
                
            sut.Execute(new DateTime());
            sut.Execute(new DateTime() + TimeSpan.FromSeconds(1));
            sut.Execute(new DateTime() + TimeSpan.FromSeconds(1.5));
                
            Assert.AreEqual(1, cookieClicker.Cookies);
        }
    }

    public class EarnCookiesByTime
    {
        private readonly EarnCookie earnCookiePresenter;
        private DateTime lastKnownTime;

        public EarnCookiesByTime(EarnCookie earnCookiePresenter)
        {
            this.earnCookiePresenter = earnCookiePresenter;
        }

        public void Execute(DateTime dateTime)
        {
            var delta = dateTime - lastKnownTime;
            if (delta.TotalSeconds >= 1)
            {
                this.earnCookiePresenter.Execute();
            }
            lastKnownTime = dateTime;
        }
    }
}