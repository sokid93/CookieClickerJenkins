using NUnit.Framework;

public class UpgradeTest
{
    [Test]
    public void ApplyUpgrade()
    {
        var cookieClicker = new CookieClicker();
        var sut = new CookiesX2Upgrade(cookieClicker);

        sut.ApplyUpgrade();
        cookieClicker.EarnCookie();
        
        Assert.AreEqual(2, cookieClicker.Cookies);
    }
}

public class CookiesX2Upgrade
{
    private readonly CookieClicker cookieClicker;

    public CookiesX2Upgrade(CookieClicker cookieClicker)
    {
        this.cookieClicker = cookieClicker;
    }

    public void ApplyUpgrade()
    {
        cookieClicker.CookiesMultiplier = 2;
    }
}
