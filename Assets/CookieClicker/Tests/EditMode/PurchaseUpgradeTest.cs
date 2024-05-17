using System;
using NUnit.Framework;

public class PurchaseUpgradeTest
{
    [Test]
    public void PurchaseUpgrade()
    {
        var cookieClicker = new CookieClicker();
        cookieClicker.EarnCookie();
        var sut = new PurchaseUpgrade(cookieClicker);

        sut.Execute();

        Assert.AreEqual(cookieClicker.CookiesMultiplier, 2);
        Assert.AreEqual(cookieClicker.Cookies, 0);
    }
}

public class PurchaseUpgrade { }