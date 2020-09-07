using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickUpgrade : MonoBehaviour
{
    public Text UpgradeInfo;
    public Text UpgradePrice;

    private int level = 1;
    private float current_APC = 1f;
    private float apc_multiplier = 0.12f;
    private float upgradePrice = 25f;
    private float price_multiplier = 0.15f;

    private void Start()
    {
        UpgradeInfo.text = "CURRENT APC : " + current_APC + "\n" + "NEW APC : " + (float)System.Math.Round((current_APC * apc_multiplier), 1) + current_APC.ToString() + "\n" + "LEVEL : " + level;
        UpgradePrice.text = upgradePrice.ToString();
    }

    public void ClickUpgradeButton()
    {
        float money = Camera.main.GetComponent<MoneyController>().money;
        if (money >= upgradePrice)
        {
            Camera.main.GetComponent<MoneyController>().Buy(upgradePrice);
            current_APC += (float)System.Math.Round((current_APC * apc_multiplier), 1);
            float new_APC = (float)System.Math.Round((current_APC * apc_multiplier), 1) + current_APC;
            upgradePrice += (float)System.Math.Round((upgradePrice * price_multiplier), 1);
            level++;
            UpgradeInfo.text = "CURRENT APC : " + current_APC + "\n" + "NEW APC : " + new_APC.ToString() + "\n" + "LEVEL : " + level;
            UpgradePrice.text = upgradePrice.ToString();
            Camera.main.GetComponent<ClickController>().ClickUpgrade(current_APC);
        }
        
    }


}
