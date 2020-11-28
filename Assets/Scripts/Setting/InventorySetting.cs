using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySetting : MonoBehaviour
{
    UserSetting userSetting;

    bool[] tower;
    void Start()
    {
        userSetting = GameObject.Find("UserSetting").GetComponent<UserSetting>();
        tower = userSetting.Tower;
    }
}
