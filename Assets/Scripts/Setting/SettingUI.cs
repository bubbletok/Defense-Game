using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingUI : MonoBehaviour
{
    public GameObject towerUI;
    public GameObject openUI, closeUI;

    TowerInformation towerInformation;
    UserSetting userSetting;

    void Start()
    {
        if(GameObject.Find("Mouse"))
            towerInformation = GameObject.Find("Mouse").GetComponent<TowerInformation>();
        if(GameObject.Find("UserSetting"))
            userSetting = GameObject.Find("UserSetting").GetComponent<UserSetting>();
    }
    public void OnClickStage1()
    {
        SceneManager.LoadScene("Normal_Stage_1");
    }
    public void OnClickStage2()
    {
        if(userSetting.stageClear[1])
            SceneManager.LoadScene("Normal_Stage_2");
    }
    public void OnClickStage3()
    {
        if (userSetting.stageClear[2])
            SceneManager.LoadScene("Normal_Stage_3");
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnClick()
    {
        openUI.SetActive(true);
    }

    public void CloseButton()
    {
        closeUI.SetActive(false);
    }

    public void towerUIClose()
    {
        towerUI.SetActive(false);
        towerInformation.openInform = false;
        towerInformation.towerSetting.open = false;
    }
}
