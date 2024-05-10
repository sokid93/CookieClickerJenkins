using NUnit.Framework;

public static class EarnCookieBuilder
{
    public static EarnCookie Create(CookieClicker cookieClicker, IOutputCounter outputCounter = default)
    {
        return new EarnCookie(cookieClicker, outputCounter ?? new MockOutputCounter());
    }
}

public class EarnCookieTests
{
    [Test]
    public void EarnCookies()
    {
        var cookieClicker = CookieClicker.CreateEmpty();
        var sut = EarnCookieBuilder.Create(cookieClicker);
        sut.Execute();
        Assert.AreEqual(1, cookieClicker.Cookies);
    }

    [Test]
    public void SignalToCookieCounter()
    {
        var cookieClicker = CookieClicker.CreateEmpty();
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
