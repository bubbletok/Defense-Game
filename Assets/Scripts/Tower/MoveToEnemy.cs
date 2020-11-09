using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MoveToEnemy : MonoBehaviour
{
    public int count;
    public float damage;
    public GameObject tower;

    AttackEnemy attackEnemy;
    TowerSetting towerSetting;
    EnemySetting enemySetting;
    GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        attackEnemy = GameObject.Find("BasicTower" + count.ToString()).GetComponent<AttackEnemy>();
        towerSetting = tower.GetComponent<TowerSetting>();
        Enemy = attackEnemy.Enemy;
        enemySetting = Enemy.GetComponent<EnemySetting>();
        damage = towerSetting.damage;
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemy != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, Enemy.transform.position, 3f * Time.deltaTime);
            enemySetting.attackedDamage = damage;
        }
        else
            Destroy(gameObject);
    }
}
