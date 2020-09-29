using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour
{
    public GameObject virusPrefab;
    public float click = 1f;
    Vector3 fromScale;

    public GameObject obj; //objekt mapy

    private void Start()
    {
        fromScale = obj.transform.localScale;
    }
    IEnumerator ScaleDownAnimation(float time) //funkcia na zvacovanie a zmensovanie mapy
    {
        float i = 0;
        float rate = 1 / time;

        
        Vector3 toScale = obj.transform.localScale / 1.5f;

        while (i < 1)
        {
            i += Time.deltaTime * rate;
            obj.transform.localScale = Vector3.Lerp(fromScale, toScale, i);
            if (toScale == obj.transform.localScale)
            {
                obj.transform.localScale = fromScale;
            }
            yield return 0;
        }
    }
    public void Click()
    {
        Camera.main.GetComponent<MoneyController>().AddMoney(click);
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        Instantiate(virusPrefab, mousePosition, Quaternion.identity);

        StartCoroutine(ScaleDownAnimation(0.1f)); //zapnutie animacie po kliknuti na mapu
    }

    public void ClickUpgrade(float newClick)
    {
        click = newClick;
    }
    
}
