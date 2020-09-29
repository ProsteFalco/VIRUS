using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandWashingUpgrade : MonoBehaviour
{
    public Text UpgradeInfo;
    public Text UpgradePrice;

    private int Level = 0;
    private bool handWashingAquired = false;
    public float current_APS = 0f;
    private float first_APS = 11f;
    private float aps_multiplier = 11f;
    private float upgradePrice = 1400f;
    private float price_multiplier = 0.1f;
   
    private void Awake()
    {
        if (PlayerPrefs.GetFloat("handWashingAPS") != 0)
        {
            Level = PlayerPrefs.GetInt("handWashingLevel");
            current_APS = PlayerPrefs.GetFloat("handWashingAPS");
            upgradePrice = PlayerPrefs.GetFloat("handWashingPrice");
            handWashingAquired = true;
        }
        else
            return;

    }
    void Start()
    {


        if (current_APS == 0)
        {
            UpgradeInfo.text = "CURRENT APS : " + Camera.main.GetComponent<PricePrintController>().ValuePrintout(current_APS) + "\n" + "NEW APS : " + first_APS.ToString() + "\n" + "LEVEL : " + Level;
        }
        else
        {
            float new_APS = (float)System.Math.Round((aps_multiplier), 1) + current_APS;

            UpgradeInfo.text = "CURRENT APS : " + Camera.main.GetComponent<PricePrintController>().ValuePrintout(current_APS) + "\n" + "NEW APS : " + Camera.main.GetComponent<PricePrintController>().ValuePrintout(new_APS) + "\n" + "LEVEL : " + Level;

        }


        UpgradePrice.text = Camera.main.GetComponent<PricePrintController>().ValuePrintout(upgradePrice);
    }

    public void HandWashingUpgradeButton()
    {
        float money = Camera.main.GetComponent<MoneyController>().money;
        if (money >= upgradePrice)
        {
            if (handWashingAquired == false)
            {
                handWashingAquired = true;
                Camera.main.GetComponent<MoneyController>().Buy(upgradePrice);
                current_APS = first_APS;
                float new_APS = (float)System.Math.Round((aps_multiplier), 1) + current_APS;
                upgradePrice += (float)System.Math.Round((upgradePrice * price_multiplier), 1);
                Level++;
                UpgradeInfo.text = "CURRENT APS : " + Camera.main.GetComponent<PricePrintController>().ValuePrintout(current_APS) + "\n" + "NEW APS : " + Camera.main.GetComponent<PricePrintController>().ValuePrintout(new_APS) + "\n" + "LEVEL : " + Level;
                UpgradePrice.text = Camera.main.GetComponent<PricePrintController>().ValuePrintout(upgradePrice);
                Camera.main.GetComponent<PlayerPrefsSaving>().PlayerPrefsSaveHandWashing(Level, current_APS, upgradePrice);
            }
            else if (handWashingAquired == true)
            {
                Camera.main.GetComponent<MoneyController>().Buy(upgradePrice);
                current_APS += (float)System.Math.Round((aps_multiplier), 1);
                float new_APS = (float)System.Math.Round((aps_multiplier), 1) + current_APS;
                upgradePrice += (float)System.Math.Round((upgradePrice * price_multiplier), 1);
                Level++;
                UpgradeInfo.text = "CURRENT APS : " + Camera.main.GetComponent<PricePrintController>().ValuePrintout(current_APS) + "\n" + "NEW APS : " + Camera.main.GetComponent<PricePrintController>().ValuePrintout(new_APS) + "\n" + "LEVEL : " + Level;
                UpgradePrice.text = Camera.main.GetComponent<PricePrintController>().ValuePrintout(upgradePrice);
                Camera.main.GetComponent<PlayerPrefsSaving>().PlayerPrefsSaveHandWashing(Level, current_APS, upgradePrice);
            }
        }

        

    }
}
