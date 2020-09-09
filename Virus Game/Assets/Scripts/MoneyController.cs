using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneyController : MonoBehaviour
{

    public float money = 0f;
    [SerializeField] private Text moneyText;
    [SerializeField] private Text apsText;

    private void Start()
    {
        money = PlayerPrefs.GetFloat("money");
    }
    void Update()
    {
        MoneyPrintout();
        Camera.main.GetComponent<PlayerPrefsSaving>().PlayerPrefsSaveMoney(money);
    }

    public void AddMoney(float money2Add)
    {
        money += money2Add;
    }

    private void MoneyPrintout()
    {

        moneyText.text = Camera.main.GetComponent<PricePrintController>().ValuePrintout(money);



    }

    public void ApsPrintout(float aps)
    {
        apsText.text = "APS : " + aps.ToString();
    }

    public void Buy(float price)
    {
        money -= price;
    }

    public void CheatCode()
    {
        money += 100;
    }

}
