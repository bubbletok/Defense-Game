using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerUpgrade : MonoBehaviour
{
    public GameObject tower, towerUI;

    int selectNumber;
    bool click;
    TowerInformation towerInformation;
    TowerSetting towerSetting;
    GameSetting gameSetting;

    void Start()
    {
        click = false;
        towerInformation = GameObject.Find("Mouse").GetComponent<TowerInformation>();
        gameSetting = GameObject.Find("SettingManager").GetComponent<GameSetting>();
    }

    void Update()
    {
        tower = towerInformation.selectTower;
        towerSetting = tower.GetComponent<TowerSetting>();
        selectNumber = towerSetting.selectNumber;
        if (click)
        {
            switch (selectNumber)
            {
                case 0:
                    if(towerSetting.upgradeLevel == 1)
                    {
                        towerSetting.damage += 5;
                        towerSetting.range += 1;
                        towerSetting.attackSpeed -= 0.25f;
                        gameSetting.gold -= towerSetting.upgradeGold;
                        towerSetting.upgradeGold += 100;
                        towerSetting.upgradeLevel++;
                        click = false;
                        towerUI.SetActive(false);
                        towerInformation.openInform = false;
                        towerInformation.towerSetting.open = false;
                    }
                    break;
                case 1:
                    if (towerSetting.upgradeLevel == 1)
                    {
                        towerSetting.damage += 2;
                        towerSetting.range += 1;
                        towerSetting.attackSpeed -= 0.1f;
                        gameSetting.gold -= towerSetting.upgradeGold;
                        towerSetting.upgradeGold += 100;
                        towerSetting.upgradeLevel++;
                        click = false;
                        towerUI.SetActive(false);
                        towerInformation.openInform = false;
                        towerInformation.towerSetting.open = false;
                    }
                    break;
                default:
                    break;
            }
        }
    }

    public void upgradeButton()
    {
        if (towerSetting.upgradeGold <= gameSetting.gold)
        {
            click = true;
        }
    }
}
