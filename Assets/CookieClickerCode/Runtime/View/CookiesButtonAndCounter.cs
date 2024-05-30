using CookieClickerCode.Runtime.Presenter;
using TMPro;
using UnityEngine;

namespace CookieClickerCode.Runtime.View
{
    public class CookiesButtonAndCounter : MonoBehaviour, IOutputCounter
    {
        private EarnCookie presenter;
        public void Configure(EarnCookie presenter)
        {
            this.presenter = presenter;
        }

        private void Start()
        {
            GetComponent<UnityEngine.UI.Button>().onClick.AddListener(PressButton);
        }

        void PressButton()
        {
            presenter.Execute();
        }

        public void UpdateCounter(int cookies)
        {
            GetComponentInChildren<TextMeshProUGUI>().text = cookies.ToString();
        }
    }
}
