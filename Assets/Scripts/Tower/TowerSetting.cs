using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSetting : MonoBehaviour
{
    public int count, selectNumber;
    public float range, damage, attackSpeed;

    void Start()
    {
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
}
