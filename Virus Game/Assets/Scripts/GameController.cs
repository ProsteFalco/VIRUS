using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameController : MonoBehaviour
{
    public GameObject shadowPanel;
    public GameObject upgradeMenuPanel;

    private GameObject AudioManagerObj;


    private void Start()
    {
        AudioManagerObj = GameObject.Find("AudioManager");
    }
    public void UpgradeMenuButton()
    {
        upgradeMenuPanel.SetActive(true);
        shadowPanel.SetActive(true);

        
        AudioManagerObj.GetComponent<AudioManager>().PitchDown();
    }

    public void CancelMenuButton()
    {
        upgradeMenuPanel.SetActive(false);
        shadowPanel.SetActive(false);

        AudioManagerObj.GetComponent<AudioManager>().PitchUp();
    }

    public void ResearchScene()
    {
        Camera.main.GetComponent<LevelLoader>().LoadResearchScene();
    }

}
