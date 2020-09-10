using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickUpgrade : MonoBehaviour
{
    public Text UpgradeInfo;
    public Text UpgradePrice;

    private int level = 1;
    private float current_APC = 1;
    private float apc_multiplier = 0.09f;
    private float upgradePrice = 25f;
    private float price_multiplier = 0.16f;
    /*private void Awake()
    {
        if (PlayerPrefs.GetFloat("current_APC") != 1)
        {

            level = PlayerPrefs.GetInt("clickLevel");
            current_APC = PlayerPrefs.GetFloat("current_APC");
            upgradePrice = PlayerPrefs.GetFloat("clickPrice");
            Camera.main.GetComponent<ClickController>().ClickUpgrade(current_APC);
        }
        else
            return;
            

    }*/
    private void Start()
    {
        
        UpgradeInfo.text = "CURRENT APC : " + Camera.main.GetComponent<PricePrintController>().ValuePrintout(current_APC) + "\n" + "NEW APC : " + Camera.main.GetComponent<PricePrintController>().ValuePrintout((float)System.Math.Round((current_APC * apc_multiplier + current_APC), 1)) + "\n" + "LEVEL : " + level;
        UpgradePrice.text = Camera.main.GetComponent<PricePrintController>().ValuePrintout(upgradePrice);
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
            UpgradeInfo.text = "CURRENT APC : " + Camera.main.GetComponent<PricePrintController>().ValuePrintout(current_APC) + "\n" + "NEW APC : " + Camera.main.GetComponent<PricePrintController>().ValuePrintout(new_APC).ToString() + "\n" + "LEVEL : " + level;
            UpgradePrice.text = Camera.main.GetComponent<PricePrintController>().ValuePrintout(upgradePrice);
            Camera.main.GetComponent<ClickController>().ClickUpgrade(current_APC);
            //Camera.main.GetComponent<PlayerPrefsSaving>().PlayerPrefsSaveClick(level, current_APC, upgradePrice);
        }
        

    }




}
