using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEditorInternal;
using UnityEngine;

public class AttackEnemy : MonoBehaviour
{
    public GameObject attack;
    public GameObject Enemy;
    public int count, id;

    TowerSetting towerSetting;
    BuildTower buildTower;
    MoveToEnemy moveToEnemy;
    CircleCollider2D rangeCircle;
    GameObject movingAttack;

    float range, damage, attackSpeed;
    bool attacking,detecting;
    void Start()
    {
        buildTower = GameObject.Find("Mouse").GetComponent<BuildTower>();
        towerSetting = gameObject.GetComponent<TowerSetting>();
        rangeCircle = gameObject.GetComponent<CircleCollider2D>();
        range = towerSetting.range;
        rangeCircle.radius = range;
        attackSpeed = towerSetting.attackSpeed;
        attacking = false;
        detecting = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("AttackedEnemy"))
        {
            detecting = true;
            id = collision.gameObject.GetInstanceID();
            Enemy = collision.gameObject;
            if (!attacking)
            {
                movingAttack = Instantiate(attack, transform.position, Quaternion.identity);
                moveToEnemy = movingAttack.GetComponent<MoveToEnemy>();
                moveToEnemy.count = towerSetting.count;
                moveToEnemy.selectNumber = towerSetting.selectNumber;
                attacking = true;
                StartCoroutine(waitforit());
            }
        }
        else if (collision.CompareTag("Enemy") && !detecting)
        {
            detecting = true;
            collision.tag = "AttackedEnemy";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(id == collision.gameObject.GetInstanceID())
            detecting = false;
    }

    IEnumerator waitforit()
    {
        yield return new WaitForSeconds(attackSpeed);
        attacking = false;
    }
}
