using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameController : MonoBehaviour
{
    public GameObject shadowPanel;
    public GameObject upgradeMenuPanel;

    public void UpgradeMenuButton()
    {
        upgradeMenuPanel.SetActive(true);
        shadowPanel.SetActive(true);
    }

    public void CancelMenuButton()
    {
        upgradeMenuPanel.SetActive(false);
        shadowPanel.SetActive(false);
    }

}
