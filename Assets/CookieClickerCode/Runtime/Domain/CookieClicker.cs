using System;

namespace CookieClickerCode.Runtime.Domain
{
    public class CookieClicker
    {
        public static CookieClicker CreateEmpty()
        {
            return new CookieClicker();
        }

        private int cookies;
        public int Cookies => cookies;
        public float CookiesMultiplier { get; set; } = 1;
        public int ClicksPerSecond { get; set; }

        public void SpendCookies(int cost)
        {
            if (cookies < cost)
                throw new Exception();

            cookies -= cost;
        }
        public void EarnCookie()
        {
            cookies += (int)CookiesMultiplier;
        }

        public bool CanSpendCookies(int quantity)
        {
            return quantity <= cookies;
        }

        public void UpgradeAutoclickerRate()
        {
            ClicksPerSecond++;
        }
        
        public void UpgradeMultiplier()
        {
            CookiesMultiplier *= 2;
        }
    }
} 