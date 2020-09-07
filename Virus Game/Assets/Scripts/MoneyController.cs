using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneyController : MonoBehaviour
{

    public float money = 0f;
    [SerializeField] private Text moneyText;
    [SerializeField] private Text apsText;

    void Update()
    {
        MoneyPrintout();
    }

    public void AddMoney(float money2Add)
    {
        money += money2Add;
    }

    private void MoneyPrintout()
    {
        if (money < 1000)
        {
            moneyText.text = System.Math.Round(money,1).ToString();
        }
        else if (money >= 1000 && money < 1000000)
        {
            moneyText.text = System.Math.Round(money / 1000, 2) + "K".ToString();
        }
        else if (money >= 1000000 && money < 1000000000)
        {
            moneyText.text = System.Math.Round(money / 1000000, 2) + "M".ToString();
        }
        else if (money >= 1000000000 && money < 1000000000000)
        {
            moneyText.text = System.Math.Round(money / 1000000000, 2) + "G".ToString();
        }
        else if (money >= 1000000000000 && money < 1000000000000000)
        {
            moneyText.text = System.Math.Round(money / 1000000000000, 2) + "T".ToString();
        }
        else if (money >= 1000000000000000 && money < 1000000000000000000)
        {
            moneyText.text = System.Math.Round(money / 1000000000000000, 2) + "P".ToString();
        }
        else if (money >= 1000000000000000000 && money < 10000000000000000000)
        {
            moneyText.text = System.Math.Round(money / 1000000000000000000, 2) + "E".ToString();
        }
        else
            moneyText.text = "Error";


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
