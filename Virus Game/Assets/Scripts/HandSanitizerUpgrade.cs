using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandSanitizerUpgrade : MonoBehaviour
{
    public Text UpgradeInfo;
    public Text UpgradePrice;

    private int Level = 0;
    private bool handSanitizerAquired = false;
    public float current_APS = 0f;
    private float aps_multiplier = 0.09f;
    private float upgradePrice = 6900f;
    private float price_multiplier = 0.15f;

    void Start()
    {
        UpgradeInfo.text = "CURRENT APS : " + 0 + "\n" + "NEW APS : " + 40.ToString() + "\n" + "LEVEL : " + Level;
        UpgradePrice.text = "6900";
    }

    public void HandSanitizerUpgradeButton()
    {
        float money = Camera.main.GetComponent<MoneyController>().money;
        if (money >= upgradePrice)
        {
            if (handSanitizerAquired == false)
            {
                handSanitizerAquired = true;
                Camera.main.GetComponent<MoneyController>().Buy(upgradePrice);
                current_APS = 40f;
                float new_APS = (float)System.Math.Round((current_APS * aps_multiplier), 1) + current_APS;
                upgradePrice += (float)System.Math.Round((upgradePrice * price_multiplier), 1);
                Level++;
                UpgradeInfo.text = "CURRENT APS : " + current_APS + "\n" + "NEW APS : " + new_APS.ToString() + "\n" + "LEVEL : " + Level;
                UpgradePrice.text = upgradePrice.ToString();
            }
            else if (handSanitizerAquired == true)
            {
                Camera.main.GetComponent<MoneyController>().Buy(upgradePrice);
                current_APS += (float)System.Math.Round((current_APS * aps_multiplier), 1);
                float new_APS = (float)System.Math.Round((current_APS * aps_multiplier), 1) + current_APS;
                upgradePrice += (float)System.Math.Round((upgradePrice * price_multiplier), 1);
                Level++;
                UpgradeInfo.text = "CURRENT APS : " + current_APS + "\n" + "NEW APS : " + new_APS.ToString() + "\n" + "LEVEL : " + Level;
                UpgradePrice.text = upgradePrice.ToString();
            }
        }

    }
}
