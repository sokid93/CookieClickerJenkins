using CookieClickerCode.Runtime.Presenter;
using UnityEngine;

namespace CookieClickerCode.Runtime.View
{
    public class PurchaseAutoclickerUpgradeButton : MonoBehaviour

    {
        private PurchaseAutoclickerUpgrade presenter;
        private QueryCookies queryCookies;

        public void Configure(PurchaseAutoclickerUpgrade presenter, QueryCookies queryCookies)
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
            presenter.Execute();
        }

        private void Update()
        {
            GetComponent<UnityEngine.UI.Button>().enabled = queryCookies.Execute();
        }
    }
}
