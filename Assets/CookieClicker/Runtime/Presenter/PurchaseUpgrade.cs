
public class PurchaseUpgrade
{
    private readonly CookieClicker cookieClicker;

    public PurchaseUpgrade(CookieClicker cookieClicker)
    {
        this.cookieClicker = cookieClicker;
    }

    public void Execute()
    {
        new CookiesX2Upgrade(cookieClicker,1).ApplyUpgrade();
    }
}
