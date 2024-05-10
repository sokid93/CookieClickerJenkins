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
        Assert.AreEqual(0, sut.Cookies);
    }

    [Test]
    public void EarnCookie()
    {
        var sut = new CookieClicker();
        sut.EarnCookie();
        Assert.AreEqual(1, sut.Cookies);
    }

    [Test]
    public void AccumulateCookies()
    {
        var sut = new CookieClicker();
        sut.EarnCookie();
        sut.EarnCookie();

        Assert.AreEqual(2, sut.Cookies);
    }
}

public class CookieClicker
{
    private int cookies = 0;
    public int Cookies => cookies;


    public void EarnCookie()
    {
        cookies++;
    }
}
