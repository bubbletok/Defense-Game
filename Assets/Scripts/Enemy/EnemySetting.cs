using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySetting : MonoBehaviour
{ 
    public float Hp, Defense, Speed, attackedDamage;
    AttackEnemy AttackEnemy;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Hp < 0)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Attack"))
        {           
            Destroy(collision.gameObject);
            Hp -= attackedDamage;
        }
    }
}
