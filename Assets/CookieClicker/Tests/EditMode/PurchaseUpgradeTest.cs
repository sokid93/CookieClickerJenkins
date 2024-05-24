using System;
using System.Net;
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

        Assert.AreEqual(2, cookieClicker.CookiesMultiplier);
        Assert.AreEqual(0, cookieClicker.Cookies);
    }
}

public class PurchaseUpgrade
{
    private readonly CookieClicker cookieClicker;

    public PurchaseUpgrade(CookieClicker cookieClicker)
    {
        this.cookieClicker = cookieClicker;
    }

    public void Execute()
    {
        new CookiesX2Upgrade(cookieClicker,1).ApplyUpgrade();
    }
}
