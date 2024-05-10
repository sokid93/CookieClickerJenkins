using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CookieClickerTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void ZeroCookiesOnStart()
    {
        CookieClicker sut = new CookieClicker();
        Assert.AreEqual(0, sut.GetCookies());
    }

    [Test]
    public void EarnCookie()
    {
        var sut = new CookieClicker();
        sut.EarnCookie();
        Assert.AreEqual(1, sut.GetCookies());
    }
}

public class CookieClicker
{
    private int cookies = 0;

    
    public int GetCookies()
    {
        return cookies;
    }

    public void EarnCookie()
    {
        throw new System.NotImplementedException();
    }
}
