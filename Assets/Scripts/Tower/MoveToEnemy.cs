using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MoveToEnemy : MonoBehaviour
{
    public int count, selectNumber, enemyId;
    public float damage;
    public GameObject tower;

    AttackEnemy attackEnemy;
    TowerSetting towerSetting;
    EnemySetting enemySetting;
    GameObject Enemy;

    void Start()
    {
        switch (selectNumber)
        {
            case 0:
                attackEnemy = GameObject.Find("BasicTower" + count.ToString()).GetComponent<AttackEnemy>();
                break;
            case 1:
                attackEnemy = GameObject.Find("SharpTower" + count.ToString()).GetComponent<AttackEnemy>();
                break;
            default:
                break;
        }
        towerSetting = tower.GetComponent<TowerSetting>();
        Enemy = attackEnemy.Enemy;
        enemySetting = Enemy.GetComponent<EnemySetting>();
        damage = towerSetting.damage;
        enemyId = attackEnemy.id;
    }

    void Update()
    {
        if (Enemy != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, Enemy.transform.position, 3f * Time.deltaTime);
        }
        else
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetInstanceID() == enemyId)
        {
            Destroy(gameObject);
            enemySetting.Hp -= damage;
        }
    }
}
