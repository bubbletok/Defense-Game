using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSetting : MonoBehaviour
{
    public int maximumRound;
    public float gold;
    public Text roundText;
    public Text goldText;
    public Text timeText;
    public Text winText;

    int round;

    SpawnEnemy spawnEnemy;
    void Start()
    {
        spawnEnemy = GameObject.Find("SpawnPosition").GetComponent<SpawnEnemy>();
        gold = 100;
    }

    void Update()
    {
        int time = (int)(spawnEnemy.spawnWaiting - spawnEnemy.spawnTimer);
        nameText(roundText, "Round : " + round.ToString());
        nameText(goldText, "Gold : " + gold.ToString());
        nameText(timeText,"Next Round : " + time.ToString());

        if(spawnEnemy.round == maximumRound)
        {
            GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
            GameObject attackedEnemy = GameObject.FindGameObjectWithTag("AttackedEnemy");
            if(enemy == null && attackedEnemy == null)
            {
                winText.text = "Win!";
            }
        }
    }

    private void LateUpdate()
    {
        round = spawnEnemy.round;
    }

    void nameText(Text text, string str)
    {
        text.text = str;
    }
}
