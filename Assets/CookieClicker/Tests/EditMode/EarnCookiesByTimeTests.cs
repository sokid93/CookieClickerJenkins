using System;
using NUnit.Framework;

namespace CookieClicker.Tests.EditMode
{
    public class EarnCookiesByTimeTests
    {
        [Test]
        public void fanhusdsdnf()
        {
            var cookieClicker = CookieClicker.CreateEmpty();
            var outputCounter = new MockOutputCounter();
            var earnCookiePresenter = new EarnCookie(cookieClicker, outputCounter);
            var sut = new EarnCookiesByTime(earnCookiePresenter);

            sut.Execute(new DateTime());

            Assert.AreEqual(0, cookieClicker.Cookies);
        }
    }

    public class EarnCookiesByTime
    {
        public EarnCookiesByTime(EarnCookie earnCookiePresenter)
        {
            throw new System.NotImplementedException();
        }

        public void Execute(DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }
}