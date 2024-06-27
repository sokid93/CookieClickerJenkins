using CookieClickerCode.Runtime.Presenter;
using UnityEngine;

namespace CookieClickerCode.Runtime.View
{
    public class PurchaseCookiesX2UpgradeButton : MonoBehaviour

    {
        private PurchaseCookiesX2Upgrade presenter;
        private QueryCookies queryCookies;

        public void Configure(PurchaseCookiesX2Upgrade presenter, QueryCookies queryCookies)
        {
            this.presenter = presenter;
            this.queryCookies = queryCookies;
        }

        private void Start()
        {
            GetComponent<UnityEngine.UI.Button>().onClick.AddListener(PressButton);
        }

        private void PressButton()
        {
            this.presenter.Execute();
        }

        private void Update()
        {
            // TODO: define queryCookies
            GetComponent<UnityEngine.UI.Button>().enabled = queryCookies.Execute();
        }
    }
}
