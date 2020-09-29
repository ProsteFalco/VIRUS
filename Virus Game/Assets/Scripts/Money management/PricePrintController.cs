using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PricePrintController : MonoBehaviour
{


    public string ValuePrintout(float value)
    {
        if (value < 1000)
        {
            return System.Math.Round(value, 1).ToString();
        }
        else if (value >= 1000 && value < 1000000)
        {
            return System.Math.Round(value / 1000, 2) + "K".ToString();
        }
        else if (value >= 1000000 && value < 1000000000)
        {
            return System.Math.Round(value / 1000000, 2) + "M".ToString();
        }
        else if (value >= 1000000000 && value < 1000000000000)
        {
            return System.Math.Round(value / 1000000000, 2) + "G".ToString();
        }
        else if (value >= 1000000000000 && value < 1000000000000000)
        {
            return System.Math.Round(value / 1000000000000, 2) + "T".ToString();
        }
        else if (value >= 1000000000000000 && value < 1000000000000000000)
        {
            return System.Math.Round(value / 1000000000000000, 2) + "P".ToString();
        }
        else if (value >= 1000000000000000000 && value < 10000000000000000000)
        {
            return System.Math.Round(value / 1000000000000000000, 2) + "E".ToString();
        }
        else
        {
            Debug.Log("Error");
            return "Error";
        }
           


    }
}
