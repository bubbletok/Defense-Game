using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerSetting : MonoBehaviour
{
    public int count, selectNumber, upgradeGold;
    public float range, damage, attackSpeed;
    public Sprite towerImage;
    public GameObject towerRange;
    public bool open;

    GameObject tempRange;
    TowerInformation towerInformation;

    void Start()
    {
        towerInformation = GameObject.Find("Mouse").GetComponent<TowerInformation>();

        tempRange = Instantiate(towerRange, transform.position, Quaternion.identity);
        tempRange.transform.localScale = new Vector3(range * 2, range * 2, 1);
        tempRange.SetActive(false);

        switch (selectNumber)
        {
            case 0:
                gameObject.name = "BasicTower" + count.ToString();
                break;
            case 1:
                gameObject.name = "SharpTower" + count.ToString();
                break;
            default:
                break;
        }
    }

    void Update()
    {
        tempRange.transform.localScale = new Vector3(range * 2, range * 2, 1);
        if (open)
        {
            tempRange.SetActive(true);
        }
        else
        {
            tempRange.SetActive(false);
        }
    }
}
