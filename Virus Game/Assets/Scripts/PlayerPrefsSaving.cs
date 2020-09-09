using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsSaving : MonoBehaviour
{

    public void Start()
    {
       // PlayerPrefs.DeleteAll();
    }
    public void PlayerPrefsSaveFaceMask(int faceMaskLevel, float faceMaskAPS, float faceMaskPrice)
    {
            PlayerPrefs.SetInt("faceMaskLevel", faceMaskLevel);
            PlayerPrefs.SetFloat("faceMaskAPS", faceMaskAPS);
            PlayerPrefs.SetFloat("faceMaskPrice", faceMaskPrice);

        PlayerPrefs.Save();
    }

    public void PlayerPrefsSaveHandWashing(int handWashingLevel, float handWashingAPS, float handWashingPrice)
    {
            PlayerPrefs.SetInt("handWashingLevel", handWashingLevel);
            PlayerPrefs.SetFloat("handWashingAPS", handWashingAPS);
            PlayerPrefs.SetFloat("handWashingPrice", handWashingPrice);

        PlayerPrefs.Save();
    }
    public void PlayerPrefsSaveHandSanitizer(int handSanitizerLevel, float handSanitizerAPS, float handSanitizerPrice)
    {
            PlayerPrefs.SetInt("handSanitizerLevel", handSanitizerLevel);
            PlayerPrefs.SetFloat("handSanitizerAPS", handSanitizerAPS);
            PlayerPrefs.SetFloat("handSanitizerPrice", handSanitizerPrice);

        PlayerPrefs.Save();
    }

    public void PlayerPrefsSavePills(int pillsLevel, float pillsAPS, float pillsPrice)
    {

            PlayerPrefs.SetInt("pillsLevel", pillsLevel);
            PlayerPrefs.SetFloat("pillsAPS", pillsAPS);
            PlayerPrefs.SetFloat("pillsPrice", pillsPrice);

        PlayerPrefs.Save();
    }

    public void PlayerPrefsSaveClick(int clickLevel, float current_APC, float clickPrice)
    {
            PlayerPrefs.SetInt("clickLevel", clickLevel);
            PlayerPrefs.SetFloat("current_APC", current_APC);
            PlayerPrefs.SetFloat("clickPrice", clickPrice);

        PlayerPrefs.Save();
    }

    public void PlayerPrefsSaveMoney(float money)
    {
            PlayerPrefs.SetFloat("money", money);

        PlayerPrefs.Save();
    }
}
