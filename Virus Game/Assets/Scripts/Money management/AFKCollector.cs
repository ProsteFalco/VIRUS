using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AFKCollector : MonoBehaviour
{

    /*
    public long ElapsedTime()
    {
        /* if (Application.platform != RuntimePlatform.Android)
             return 0;

         AndroidJavaClass systemClock = new AndroidJavaClass("android.os.SystemClock");

         Debug.Log(systemClock.CallStatic<long>("elapsedRealtime"));

         return systemClock.CallStatic<long>("elapsedRealtime"); 
        return long.Parse(System.DateTime.UtcNow.ToString("yyyyMMddHHmmss"));
    } */

    DateTime currentDate;
    DateTime oldDate;
    TimeSpan difference;
    void Awake()
    {
        currentDate = System.DateTime.Now;

        long temp = (long) Convert.ToInt64(PlayerPrefs.GetString("sysString"));

        DateTime oldDate = DateTime.FromBinary(temp);

        difference = currentDate.Subtract(oldDate);


    }

    public float diffSecs()
    {
        return System.Convert.ToSingle(difference.TotalSeconds);
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.SetString("sysString", System.DateTime.Now.ToBinary().ToString());
    }
}
