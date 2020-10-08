using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ResearchController : MonoBehaviour
{

    List<int> unlocked = new List<int>();
    public GameObject panel;
    public Text priceDNA_Text;
    public Text priceRP_Text;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Unlock()
    {
        
    }

    public void ShowPanel(int priceDNA, int priceRP)
    {
        
        panel.SetActive(true);
        priceDNA_Text.text = Camera.main.GetComponent<PricePrintController>().ValuePrintout(priceDNA) + " DNA";
        priceRP_Text.text = Camera.main.GetComponent<PricePrintController>().ValuePrintout(priceRP) + " RP";

    }

    public void HidePanel()
    {
        panel.SetActive(false);
    }

    
}
