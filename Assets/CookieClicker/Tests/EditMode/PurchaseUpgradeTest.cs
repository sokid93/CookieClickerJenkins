using System;
using System.Net;
using NUnit.Framework;

public class PurchaseUpgradeTest
{
    [Test]
    public void PurchaseUpgrade()
    {
        var cookieClicker = new CookieClicker();
        var outputCounter = new MockOutputCounter();
        cookieClicker.EarnCookie();
        var sut = new PurchaseUpgrade(cookieClicker, outputCounter);

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
        var sut = new PurchaseUpgrade(cookieClicker, outputCounter);
        
        sut.Execute();
        
        Assert.AreEqual(1, outputCounter.DisplayedCookies);
    }
}
