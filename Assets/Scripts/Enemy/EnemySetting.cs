using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySetting : MonoBehaviour
{
    public int _name;
    public float Hp, Defense, Speed, earnedGold;
    public GameObject coinEffect, baseBar,hpBar, hpbar, hpbarBase;
    public ParticleSystem particle;

    GameSetting gameSetting;
    Vector2 position;

    void Start()
    {
        position = new Vector2(transform.position.x, transform.position.y + 0.6f);
        gameSetting = GameObject.Find("SettingManager").GetComponent<GameSetting>();
        hpbarBase = Instantiate(baseBar, position, Quaternion.identity);
        hpbar = Instantiate(hpBar, position, Quaternion.identity);
        hpbarBase.transform.localScale = new Vector3(Hp / 50, 1, 1);
    }

    void Update()
    {
        hpbar.transform.localScale = new Vector3(Hp / 50, 1, 1);
        hpbar.transform.position = new Vector2(transform.position.x, transform.position.y + 0.6f);
        hpbarBase.transform.position = new Vector2(transform.position.x, transform.position.y + 0.6f);
    }
    void LateUpdate()
    {
        if (Hp < 0)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
            Destroy(hpbar);
            Destroy(hpbarBase);
            Instantiate(coinEffect, transform.position, Quaternion.identity);
            Instantiate(particle, transform.position, Quaternion.identity);
            gameSetting.gold += earnedGold;
            //get materials
        }
    }
}
