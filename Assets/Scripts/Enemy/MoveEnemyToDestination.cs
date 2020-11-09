using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyToDestination : MonoBehaviour
{
    EnemySetting enemySetting;
    int state = 1;
    float speed;
    bool arrival = false;

    GameObject Dest1, Dest2, Dest3;
    // Start is called before the first frame update

    private void Start()
    {
        enemySetting = gameObject.GetComponent<EnemySetting>();
        speed = enemySetting.Speed;
        Dest1 = GameObject.Find("Dest1");
        Dest2 = GameObject.Find("Dest2");
        Dest3 = GameObject.Find("Dest3");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (!arrival)
        {
            if (state == 1)
            {
                move(4);
                //if (transform.position == new Vector3(-1.5f, -0.5f, 0
                if(transform.position == Dest1.transform.position)
                    state = 2;
            }
            else if (state == 2)
            {
                move(1);
                //if (transform.position == new Vector3(3.5f, -0.5f, 0))
                if (transform.position == Dest2.transform.position)
                    state = 3;
            }
            else if (state == 3)
            {
                move(4);
                //if (transform.position == new Vector3(3.5f, -4.5f, 0))
                if (transform.position == Dest3.transform.position)
                    arrival = true;
            }
        }
        if (arrival)
            Destroy(gameObject);
    }
    void move(int dir)
    {
        switch (dir)
        {
            case 1:
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                break;
            case 2:
                transform.Translate(Vector2.up * speed * Time.deltaTime);
                break;
            case 3:
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                break;
            case 4:
                transform.Translate(Vector2.down * speed * Time.deltaTime);
                break;
            default:
                break;
        }
    }
}
