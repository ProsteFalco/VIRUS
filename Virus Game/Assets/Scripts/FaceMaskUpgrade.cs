using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceMaskUpgrade : MonoBehaviour
{
    public Text UpgradeInfo;
    public Text UpgradePrice;

    private int Level = 0;
    private bool faceMaskAquired = false;
    public float current_APS = 0f;
    private float aps_multiplier = 0.09f;
    private float upgradePrice = 180f;
    private float price_multiplier = 0.15f;

    void Start()
    {
        UpgradeInfo.text = "CURRENT APS : " + 0 + "\n" + "NEW APS : " + 0.5.ToString() + "\n" + "LEVEL : " + Level;
        UpgradePrice.text = "180";
    }

    public void FaceMaskUpgradeButton()
    {
        float money = Camera.main.GetComponent<MoneyController>().money;

        if (money >= upgradePrice)
        {
            if (faceMaskAquired == false)
            {
                faceMaskAquired = true;
                Camera.main.GetComponent<MoneyController>().Buy(upgradePrice);
                current_APS = 3f;
                float new_APC = (float)System.Math.Round((current_APS * aps_multiplier), 1) + current_APS;
                upgradePrice += (float)System.Math.Round((upgradePrice * price_multiplier), 1);
                Level++;
                UpgradeInfo.text = "CURRENT APS : " + current_APS + "\n" + "NEW APS : " + new_APC.ToString() + "\n" + "LEVEL : " + Level;
                UpgradePrice.text = upgradePrice.ToString();
            }
            else if (faceMaskAquired == true)
            {
                Camera.main.GetComponent<MoneyController>().Buy(upgradePrice);
                current_APS += (float)System.Math.Round((current_APS * aps_multiplier), 1);
                float new_APC = (float)System.Math.Round((current_APS * aps_multiplier), 1) + current_APS;
                upgradePrice += (float)System.Math.Round((upgradePrice * price_multiplier), 1);
                Level++;
                UpgradeInfo.text = "CURRENT APS : " + current_APS + "\n" + "NEW APS : " + new_APC.ToString() + "\n" + "LEVEL : " + Level;
                UpgradePrice.text = upgradePrice.ToString();
            }
        }
      
    }
}
