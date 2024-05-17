using System;
using NUnit.Framework;

public class UpgradeTest
{
    [Test]
    public void ApplyCookiesX2Upgrade()
    {
        var cookieClicker = new CookieClicker();
        var sut = new CookiesX2Upgrade(cookieClicker);

        sut.ApplyUpgrade();
        cookieClicker.EarnCookie();
        
        Assert.AreEqual(2, cookieClicker.Cookies);
    }
    
    [Test]
    public void ApplyCookiesX2UpgradeTwice()
    {
        var cookieClicker = new CookieClicker();
        var sut = new CookiesX2Upgrade(cookieClicker);
        
        sut.ApplyUpgrade();
        sut.ApplyUpgrade();
        cookieClicker.EarnCookie();
        
        Assert.AreEqual(4, cookieClicker.Cookies);
    }

    [Test]
    public void SpendCookieToBuyUpgrade()
    {
        var cookieClicker = new CookieClicker();
        var sut = new CookiesX2Upgrade(cookieClicker, 1);
        
        cookieClicker.EarnCookie();
        sut.ApplyUpgrade();
        
        Assert.AreEqual(0, cookieClicker.Cookies);
    }
    
}

public class CookiesX2Upgrade
{
    private readonly CookieClicker cookieClicker;
    private int cost;

    public CookiesX2Upgrade(CookieClicker cookieClicker, int cost=0)
    {
        this.cookieClicker = cookieClicker;
        this.cost = cost;
    }

    public void ApplyUpgrade()
    {
        if (cookieClicker.Cookies < cost)
            throw new Exception();
        
        cookieClicker.Cookies -= cost;
        cookieClicker.CookiesMultiplier *= 2;

    }
}
