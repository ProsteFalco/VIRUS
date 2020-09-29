using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class APSController : MonoBehaviour
{
    private float APS = 0f;

    void Start()
    {
        AddAPS();
        Camera.main.GetComponent<MoneyController>().ApsPrintout((float)System.Math.Round(APS, 1));

        float toAdd = Camera.main.GetComponent<AFKCollector>().diffSecs() * APS;
        Camera.main.GetComponent<MoneyController>().AddMoney(toAdd);
        /*GameObject test;
        test = GameObject.Find("DebugText");
        test.GetComponent<Text>().text = "Bol si prec " + System.Math.Round((Camera.main.GetComponent<AFKCollector>().diffSecs() / 60), 1).ToString() + " minut a prislo tolkoto money: " + toAdd.ToString();*/

        StartCoroutine(APSCoroutine());
    }
    private void Update()
    {
        AddAPS();
        Camera.main.GetComponent<MoneyController>().ApsPrintout((float)System.Math.Round(APS,1));
    }
    public void AddAPS()
    {
        APS = Camera.main.GetComponent<HandWashingUpgrade>().current_APS +
              Camera.main.GetComponent<FaceMaskUpgrade>().current_APS +
              Camera.main.GetComponent<HandSanitizerUpgrade>().current_APS +
              Camera.main.GetComponent<PillsUpgrade>().current_APS;
    }
    public IEnumerator APSCoroutine()
    {

        Camera.main.GetComponent<MoneyController>().AddMoney(APS/4);

        
        yield return new WaitForSeconds(0.25f);
        StartCoroutine(APSCoroutine());
    }
}
