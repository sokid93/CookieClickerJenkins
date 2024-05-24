
public class PurchaseUpgrade
{
    private readonly CookieClicker cookieClicker;
    private readonly IOutputCounter outputCounter;

    public PurchaseUpgrade(CookieClicker cookieClicker, IOutputCounter outputCounter)
    {
        this.cookieClicker = cookieClicker;
        this.outputCounter = outputCounter;
    }

    public void Execute()
    {
        new CookiesX2Upgrade(cookieClicker,1).ApplyUpgrade();
        outputCounter.UpdateCounter(cookieClicker.Cookies);
    }
}
