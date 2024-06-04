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
            var purchaseUpgradeButton = FindObjectOfType<PurchaseUpgradeButton>();
            var cookiesByTimeTimer = FindObjectOfType<CookiesByTimeTimer>();
            var purchaseUpgradePresenter = new PurchaseUpgrade(cookieClicker, cookiesButtonAndCounter);
            var earnCookiePresenter = new EarnCookie(cookieClicker, cookiesButtonAndCounter);
            var queryCookiesPresenter = new QueryCookies(cookieClicker);
            var earnCookiesByTime = new EarnCookiesByTime(earnCookiePresenter, cookieClicker);
            cookiesButtonAndCounter.Configure(earnCookiePresenter);
            purchaseUpgradeButton.Configure(purchaseUpgradePresenter, queryCookiesPresenter);
            cookiesByTimeTimer.Configure(earnCookiesByTime);
        }
    }
}