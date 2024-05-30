using CookieClickerCode.Runtime.Domain;
using CookieClickerCode.Runtime.Presenter;
using NUnit.Framework;

namespace CookieClickerCode.Tests.EditMode
{
    public static class EarnCookieBuilder
    {
        public static EarnCookie Create(CookieClicker cookieClicker, IOutputCounter outputCounter = default)
        {
            return new EarnCookie(cookieClicker, outputCounter ?? new MockOutputCounter());
        }
    }

    public class EarnCookieTests
    {
        [Test]
        public void EarnCookies()
        {
            var cookieClicker = CookieClicker.CreateEmpty();
            var sut = EarnCookieBuilder.Create(cookieClicker);
            sut.Execute();

            Assert.AreEqual(1, cookieClicker.Cookies);
        }

        [Test]
        public void SignalToCookieCounter()
        {
            var cookieClicker = CookieClicker.CreateEmpty();
            var outputCounter = new MockOutputCounter();
            var sut = new EarnCookie(cookieClicker, outputCounter);
            sut.Execute();

            Assert.AreEqual(1, outputCounter.DisplayedCookies);
        }

        [Test]
        public void Display2Cookies()
        {
            var cookieClicker = CookieClicker.CreateEmpty();
            var outputCounter = new MockOutputCounter();
            var sut = EarnCookieBuilder.Create(cookieClicker, outputCounter);

            sut.Execute();
            sut.Execute();

            Assert.AreEqual(2, outputCounter.DisplayedCookies);
        }
    }

    public class MockOutputCounter : IOutputCounter
    {
        public int DisplayedCookies { get; private set; }

        public void UpdateCounter(int cookies)
        {
            DisplayedCookies = cookies;
        }
    }
}