using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BuildTower : MonoBehaviour
{
    public Tilemap towerBase;
    public Tile getTile;
    public Tile Tower;
    public GameObject[] tower;
    public int[] count;
    public int selectNumber, buildNumber;
    public bool towerSelected;
    Vector3Int position;
    Vector3Int[] positions;

    GameSetting gameSetting;
    TowerSetting towerSetting;
    TowerInformation towerInformation;

    int x, y, allCount;
    int[] expense;
    bool exist;
    void Start()
    {
        allCount = 0;
        buildNumber = 0;
        selectNumber = 0;
        count = new int[99];
        exist = false;
        positions = new Vector3Int[99];
        expense = new int[5];
        expense[0] = 20;
        expense[1] = 25;
        expense[2] = 15;
        expense[3] = 40;

        gameSetting = GameObject.Find("SettingManager").GetComponent<GameSetting>();
        towerInformation = GameObject.Find("Mouse").GetComponent<TowerInformation>();

        towerSelected = false;
    }
    void Update()
    {
        int x = transform.position.x > 0 ? (int)transform.position.x : (int)transform.position.x - 1;
        int y = transform.position.y > 0 ? (int)transform.position.y : (int)transform.position.y - 1;
        position = new Vector3Int(x, y, 0);

        if (towerBase.GetTile(position) == getTile)
        {
            exist = false;
            for(int i=0; i<allCount; i++)
            {
                if (positions[i] == position)
                {
                    exist = true;
                    break;
                }
                else
                    exist = false;
            }
            if (!exist)
            {
                if (Input.GetMouseButtonDown(0) && towerSelected)
                {
                    if (expense[buildNumber] <= gameSetting.gold)
                    {
                        GameObject Tower = Instantiate(tower[buildNumber], new Vector3(position.x + 0.5f, position.y + 0.5f, 0), Quaternion.identity);
                        towerInformation.usedTower[allCount] = Tower;
                        towerSetting = Tower.GetComponent<TowerSetting>();
                        positions[count[buildNumber]] = position;
                        count[buildNumber]++;
                        allCount++;
                        gameSetting.gold -= expense[buildNumber];
                        towerSetting.count = count[buildNumber];
                        towerSetting.selectNumber = buildNumber;
                        towerSelected = false;
                    }
                }
            }
        }
    }
    void nameTower(GameObject tower, string str)
    {
        tower.name = str;
    }
}
