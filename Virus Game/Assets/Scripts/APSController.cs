using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class APSController : MonoBehaviour
{
    private float APS = 0f;

    void Start()
    {
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
              Camera.main.GetComponent<HandSanitizerUpgrade>().current_APS;
    }
    public IEnumerator APSCoroutine()
    {
        Camera.main.GetComponent<MoneyController>().AddMoney(APS);
        yield return new WaitForSeconds(1);
        StartCoroutine(APSCoroutine());
    }
}
