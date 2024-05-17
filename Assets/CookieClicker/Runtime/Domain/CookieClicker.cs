public class CookieClicker
{
    public static CookieClicker CreateEmpty()
    {
        return new CookieClicker();
    }

    private int cookies = 0;
    public int Cookies => cookies;
    public float CookiesMultiplier { get; set; } = 1;


    public void EarnCookie()
    {
        cookies += (int)CookiesMultiplier;
    }
}