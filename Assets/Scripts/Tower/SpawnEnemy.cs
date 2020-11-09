using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;
    public int count;
    public float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        spawnTime = 3f;
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator Spawn()
    {
        Instantiate(Enemy, transform.position, Quaternion.identity);
        count--;
        yield return new WaitForSeconds(spawnTime);
        if (count != 0)
            StartCoroutine(Spawn());
    }
}
