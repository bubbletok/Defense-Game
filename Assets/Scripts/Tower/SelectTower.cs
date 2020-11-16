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

    public void basicTower()
    {
        buildTower.buildNumber = 0;
    }

    public void sharpTower()
    {
        buildTower.buildNumber = 1;
    }
}
