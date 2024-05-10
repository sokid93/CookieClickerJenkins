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

    [Test]
    public void SignalToCookieCounter()
    {
        var cookieClicker = new CookieClicker();
        var outputCounter = new MockOutputCounter();
        var sut = new EarnCookie(cookieClicker, outputCounter);
        sut.Execute();
        Assert.IsTrue(outputCounter.updated);
    }
}

public class MockOutputCounter : IOutputCounter
{
    public bool updated = false;
    public void UpdateCounter() => updated = true;
}

public interface IOutputCounter
{
    void UpdateCounter();
}

public class EarnCookie
{
    CookieClicker cookieClicker;
    private readonly IOutputCounter outputCounter;

    public EarnCookie(CookieClicker cookieClicker)
    {
        this.cookieClicker = cookieClicker;
    }

    public EarnCookie(CookieClicker cookieClicker, IOutputCounter outputCounter)
    {
        this.cookieClicker = cookieClicker;
        this.outputCounter = outputCounter;
    }

    public void Execute()
    {
        cookieClicker.EarnCookie();
        outputCounter.UpdateCounter();
    }
}
