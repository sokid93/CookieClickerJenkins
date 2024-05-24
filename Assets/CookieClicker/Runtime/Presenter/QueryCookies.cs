
public class QueryCookies
{
    CookieClicker cookieClicker;
    public QueryCookies(CookieClicker cookieClicker) {
        this.cookieClicker = cookieClicker;
    }

    public bool Execute() => this.cookieClicker.CanSpendCookies(1);
}