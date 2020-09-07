using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour
{
    public GameObject virusPrefab;
    public float click = 1f;

    public void Click()
    {
        Camera.main.GetComponent<MoneyController>().AddMoney(click);
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        Instantiate(virusPrefab, mousePosition, Quaternion.identity);
    }

    public void ClickUpgrade(float newClick)
    {
        click = newClick;
    }
    
}
