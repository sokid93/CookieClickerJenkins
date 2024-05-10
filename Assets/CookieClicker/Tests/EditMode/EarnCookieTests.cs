using NUnit.Framework;

public class EarnCookieTests
{
    [Test]
    public void EarnCookies()
    {
        var cookieClicker = new CookieClicker();
        var sut = new EarnCookie(cookieClicker);
        sut.Execute();
        Assert.AreEqual(1, cookieClicker.Cookies);
    }
}
public class EarnCookie
{
    CookieClicker cookieClicker;
    public EarnCookie(CookieClicker cookieClicker)
    {
        this.cookieClicker = cookieClicker;
    }

    public void Execute()
    {
        cookieClicker.EarnCookie();
    }
}
