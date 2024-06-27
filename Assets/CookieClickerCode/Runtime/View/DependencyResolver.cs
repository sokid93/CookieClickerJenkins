using CookieClickerCode.Runtime.Domain;
using CookieClickerCode.Runtime.Presenter;
using UnityEngine;

namespace CookieClickerCode.Runtime.View
{
    public class DependencyResolver : MonoBehaviour
    {
        private void Awake()
        {
            CookieClicker cookieClicker = CookieClicker.CreateEmpty();
            var cookiesButtonAndCounter = FindObjectOfType<CookiesButtonAndCounter>();
            var PurchaseCookiesX2UpgradeButton = FindObjectOfType<PurchaseCookiesX2UpgradeButton>();
            var cookiesByTimeTimer = FindObjectOfType<CookiesByTimeTimer>();
            var PurchaseCookiesX2UpgradePresenter = new PurchaseCookiesX2Upgrade(cookieClicker, cookiesButtonAndCounter);
            var earnCookiePresenter = new EarnCookie(cookieClicker, cookiesButtonAndCounter);
            var queryCookiesPresenter = new QueryCookies(cookieClicker);
            var earnCookiesByTime = new EarnCookiesByTime(earnCookiePresenter, new Autoclicker(cookieClicker));
            cookiesButtonAndCounter.Configure(earnCookiePresenter);
            PurchaseCookiesX2UpgradeButton.Configure(PurchaseCookiesX2UpgradePresenter, queryCookiesPresenter);
            cookiesByTimeTimer.Configure(earnCookiesByTime);
        }
    }
}