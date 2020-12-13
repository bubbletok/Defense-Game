using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public int round, spawnWaiting;
    public float spawnTimer;
    public GameObject[] Enemy;

    GameSetting gameSetting;
    int restWaiting;
    float restTimer;
    bool spawning, rest, inform;

    void Start()
    {
        restTimer = 0;
        restWaiting = 10;
        spawnTimer = 0;
        round = 0;

        spawning = false;
        rest = false;
        inform = false;
    }

    void Update()
    {
        if (rest)
            restTimer += Time.deltaTime;
        if (restTimer >= restWaiting)
        {
            rest = false;
            restTimer = 0;
        }

        if (spawnTimer > spawnWaiting)
        {
            spawning = true;
            spawnTimer = 0;
            round++;
        }
        if (!spawning && !rest)
        {
            spawnTimer += Time.deltaTime;
            if (!inform)
            {
                switch (round)
                {
                    case 0:
                        inform = true;
                        break;
                    default:
                        break;
                }
            }
        }
        else if (spawning)
        {
            inform = false;
            switch (round)
            {
                case 1:
                    StartCoroutine(Spawn(0, 5));
                    spawning = false;
                    rest = true;
                    break;
                case 2:
                    StartCoroutine(Spawn(1, 5));
                    spawning = false;
                    rest = true;
                    break;
                case 3:
                    StartCoroutine(Spawn(2, 5));
                    spawning = false;
                    rest = true;
                    break;
                case 4:
                    StartCoroutine(Spawn(3, 5));
                    spawning = false;
                    rest = true;
                    break;
                case 20:
                    break;
                default:
                    break;
            }
        }
    }

    IEnumerator Spawn(int number, int count)
    {
        GameObject spawnedEnemy = Instantiate(Enemy[number], transform.position, Quaternion.identity);
        spawnedEnemy.name = count.ToString();
        count--;
        yield return new WaitForSeconds(1f);
        if (count == 0)
            spawning = false;
        else
            StartCoroutine(Spawn(number,count));
    }
}
