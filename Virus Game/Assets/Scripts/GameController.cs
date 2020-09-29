using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameController : MonoBehaviour
{

    public GameObject upgradeMenuPanel;
    public GameObject gamePanel;
    public GameObject BG;
    public GameObject BG2;

    private GameObject AudioManagerObj;


    private void Start()
    {
        upgradeMenuPanel.SetActive(false);
        BG.SetActive(true);
        BG2.SetActive(false);
        gamePanel.SetActive(true);
        AudioManagerObj = GameObject.Find("AudioManager");
    }
    public void UpgradeMenuButton()
    {
        upgradeMenuPanel.SetActive(true);
        BG.SetActive(false);
        BG2.SetActive(true);
        gamePanel.SetActive(false);
        

        
        AudioManagerObj.GetComponent<AudioManager>().PitchDown();
    }

    public void CancelMenuButton()
    {
        upgradeMenuPanel.SetActive(false);
        BG.SetActive(true);
        BG2.SetActive(false);
        gamePanel.SetActive(true);


        AudioManagerObj.GetComponent<AudioManager>().PitchUp();
    }

    public void ResearchScene()
    {
        Camera.main.GetComponent<LevelLoader>().LoadResearchScene();
    }

}
