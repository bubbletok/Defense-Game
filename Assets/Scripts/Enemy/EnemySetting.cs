using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySetting : MonoBehaviour
{ 
    public float Hp, Defense, Speed, earnedGold;
    public GameObject coinEffect;

    AttackEnemy AttackEnemy;
    GameSetting gameSetting;

    void Start()
    {
        gameSetting = GameObject.Find("SettingManager").GetComponent<GameSetting>();
        //Instanciate(hpBar, new Vector3(trasform.position.x,transform.position.y + 2,0),Quaternion.identify)
    }

    void Update()
    {
        if(Hp < 0)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
            Instantiate(coinEffect, transform.position, Quaternion.identity);
            gameSetting.gold += earnedGold;
        }


    }
}
