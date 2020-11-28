using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingUI : MonoBehaviour
{

    public GameObject inventoryUI;
    public GameObject towerInventoryUI;
    public GameObject towerUI;

    TowerInformation towerInformation;

    void Start()
    {
        towerInformation = GameObject.Find("Mouse").GetComponent<TowerInformation>();
    }
    public void OnClickStage()
    {
        SceneManager.LoadScene("Normal_Stage_1");
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void InventoryOnClick()
    {
        inventoryUI.SetActive(true);
    }
    public void InventoryClose()
    {
        inventoryUI.SetActive(false);
    }

    public void towerInventoryOnClick()
    {
        towerInventoryUI.SetActive(true);
    }

    public void towerInventoryClose()
    {
        towerInventoryUI.SetActive(false);
    }

    public void towerUIClose()
    {
        towerUI.SetActive(false);
        towerInformation.towerSetting.open = false;
    }

}
