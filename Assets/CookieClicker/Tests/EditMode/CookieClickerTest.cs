using NUnit.Framework;

public class CookieClickerTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void ZeroCookiesOnStart()
    {
        CookieClicker sut = CookieClicker.CreateEmpty();
        Assert.AreEqual(0, sut.Cookies);
    }

    [Test]
    public void EarnCookie()
    {
        var sut = CookieClicker.CreateEmpty();
        sut.EarnCookie();
        Assert.AreEqual(1, sut.Cookies);
    }

    [Test]
    public void AccumulateCookies()
    {
        var sut = CookieClicker.CreateEmpty();
        sut.EarnCookie();
        sut.EarnCookie();

        Assert.AreEqual(2, sut.Cookies);
    }
}
