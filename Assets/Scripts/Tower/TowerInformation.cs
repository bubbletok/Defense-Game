using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerInformation : MonoBehaviour
{
    public GameObject tower, towerUI, range, selectTower;
    public GameObject[] usedTower;
    public Text damageText;
    public Text attackSpeedText;
    public Text rangeText;
    public Text upgradeGoldText;
    public Image towerImage;
    public TowerSetting towerSetting;
    public bool openInform;

    void Start()
    {
        usedTower = new GameObject[99];
        openInform = false;
    }

    void Update()
    {
        for (int i = 0; usedTower[i] != null; i++)
        {
            tower = usedTower[i];
            if (tower.transform.position.x + 0.5 >= transform.position.x && tower.transform.position.x - 0.5 <= transform.position.x
                 && tower.transform.position.y + 0.5 >= transform.position.y && tower.transform.position.y - 0.5 <= transform.position.y)
            {
                if (Input.GetMouseButtonDown(1) && !openInform)
                {
                    selectTower = tower;
                    towerUI.SetActive(true);
                    towerSetting = selectTower.GetComponent<TowerSetting>();
                    damageText.text = "Damage : " + towerSetting.damage.ToString();
                    attackSpeedText.text = "Attack Speed : " + towerSetting.attackSpeed.ToString();
                    rangeText.text = "Range : " + towerSetting.range.ToString();
                    upgradeGoldText.text = "Upgrade Gold : " + towerSetting.upgradeGold.ToString();
                    towerImage.sprite = towerSetting.towerImage;
                    towerSetting.open = true;
                    openInform = true;
                }
            }
        }

        /*if (openInform)
        {
            if (!(towerUI.transform.position.x + 100 >= transform.position.x && towerUI.transform.position.x - 100 <= transform.position.x
                     && towerUI.transform.position.y + 100 >= transform.position.y && towerUI.transform.position.y - 100 <= transform.position.y))
            {
                Debug.Log(towerUI.transform.position);
                if (Input.GetMouseButtonDown(0))
                {
                    towerUI.SetActive(false);
                    towerSetting.open = false;
                    openInform = false;
                }
            }
        }*/
    }
}
