
public class QueryCookies
{
    CookieClicker cookieClicker;
    public void QueryCookies(Cookieclicker cookieclicker) {
        this.cookieClicker = cookieClicker;
    }

    public bool Execute() => this.cookieClicker.CanSpendCookies(1);
}