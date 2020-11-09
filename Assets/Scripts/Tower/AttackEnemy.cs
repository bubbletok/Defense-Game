using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class AttackEnemy : MonoBehaviour
{
    public GameObject attack;
    public GameObject Enemy;
    public int count;

    TowerSetting towerSetting;
    BuildTower buildTower;
    MoveToEnemy moveToEnemy;
    CircleCollider2D rangeCircle;
    GameObject movingAttack;

    float range, damage, attackSpeed;
    bool attacking,detecting;
    // Start is called before the first frame update
    void Start()
    {
        buildTower = GameObject.Find("Mouse").GetComponent<BuildTower>();
        towerSetting = gameObject.GetComponent<TowerSetting>();
        rangeCircle = gameObject.GetComponent<CircleCollider2D>();
        range = towerSetting.range;
        rangeCircle.radius = range;
        attackSpeed = towerSetting.attackSpeed;
        count = buildTower.count;
        attacking = false;
        detecting = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            if (!detecting)
                collision.tag = "AttackedEnemy";
        }
        else if (collision.CompareTag("AttackedEnemy"))
        {
            detecting = true;
            Enemy = collision.gameObject;
            if (!attacking)
            {
                movingAttack = Instantiate(attack, transform.position, Quaternion.identity);
                moveToEnemy = movingAttack.GetComponent<MoveToEnemy>();
                moveToEnemy.count = count;
                attacking = true;
                StartCoroutine(waitforit());
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("AttackedEnemy"))
        {
            detecting = false;
        }
    }

    IEnumerator waitforit()
    {
        yield return new WaitForSeconds(attackSpeed);
        attacking = false;
    }
}
