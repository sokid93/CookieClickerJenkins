using UnityEngine;

public class PurchaseUpgradeButton : MonoBehaviour

{
    private PurchaseUpgrade presenter;

    public void Configure(PurchaseUpgrade presenter)
    {
        this.presenter = presenter;
    }
}
