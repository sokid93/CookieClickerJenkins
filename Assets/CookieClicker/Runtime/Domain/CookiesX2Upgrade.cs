
public class CookiesX2Upgrade
{
    private readonly CookieClicker cookieClicker;
    private int cost;

    public CookiesX2Upgrade(CookieClicker cookieClicker, int cost=0)
    {
        this.cookieClicker = cookieClicker;
        this.cost = cost;
    }

    public void ApplyUpgrade()
    {
        cookieClicker.SpendCookies(cost);
        cookieClicker.CookiesMultiplier *= 2;
    }
}

