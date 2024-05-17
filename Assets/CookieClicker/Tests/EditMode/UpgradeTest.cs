using NUnit.Framework;

public class UpgradeTest
{
    [Test]
    public void ApplyUpgrade()
    {
        var cookieClicker = new CookieClicker();
        var sut = new CookiesX2Upgrade(cookieClicker);

        // TODO: stuff
    }
}

public class CookiesX2Upgrade
{
    private readonly CookieClicker cookieClicker;

    public Upgrade(CookieClicker cookieClicker)
    {
        this.cookieClicker = cookieClicker;
    }

    public void ApplyUpgrade()
    {

    }
}
