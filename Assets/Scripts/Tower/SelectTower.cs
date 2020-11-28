using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTower : MonoBehaviour
{
    BuildTower buildTower;
    void Start()
    {
        buildTower = GameObject.Find("Mouse").GetComponent<BuildTower>();
    }

    public void None()
    {
        buildTower.towerSelected = false;
    }

    public void basicTower()
    {
        buildTower.buildNumber = 0;
        buildTower.towerSelected = true;
    }

    public void sharpTower()
    {
        buildTower.buildNumber = 1;
        buildTower.towerSelected = true;
    }
}
