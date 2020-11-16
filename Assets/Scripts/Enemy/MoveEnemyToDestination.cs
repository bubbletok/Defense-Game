using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MoveEnemyToDestination : MonoBehaviour
{
    EnemySetting enemySetting;
    float speed;

    GameObject Dest, destination;
    int destCount;
    // Start is called before the first frame update

    private void Start()
    {
        enemySetting = gameObject.GetComponent<EnemySetting>();
        destination = GameObject.Find("Destination");
        speed = enemySetting.Speed;
        destCount = 1;
        Dest = GameObject.Find("Dest" + destCount.ToString());
    }

    private void Update()
    {
        if (transform.position == Dest.transform.position)
        {
            destCount++;
            Dest = GameObject.Find("Dest" + destCount.ToString());
        }
        if (transform.position == destination.transform.position)
            Destroy(gameObject);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, Dest.transform.position,speed * Time.deltaTime);
    }
}
