using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSetting : MonoBehaviour
{
    public int maximumRound, life;
    public float gold;
    public Text roundText;
    public Text goldText;
    public Text timeText;
    public Text winText;
    public Text lifeText;
    public Image loseImage;

    int round;

    SpawnEnemy spawnEnemy;
    void Start()
    {
        spawnEnemy = GameObject.Find("SpawnPosition").GetComponent<SpawnEnemy>();
        gold = 500;
        life = 20;
        maximumRound = 20;
    }

    void Update()
    {
        int time = (int)(spawnEnemy.spawnWaiting - spawnEnemy.spawnTimer);
        nameText(roundText, "Round : " + round.ToString());
        nameText(goldText, "Gold : " + gold.ToString());
        nameText(timeText,"Next Round : " + time.ToString());
        nameText(lifeText, "Life : " + life.ToString());

        if (spawnEnemy.round == maximumRound)
        {
            GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
            GameObject attackedEnemy = GameObject.FindGameObjectWithTag("AttackedEnemy");
            if(enemy == null && attackedEnemy == null)
            {
                winText.text = "Win!";
                //win UI
                //-> click next button -> MainMenu
                //-> get reward(materials, tower, etc)
            }
        }
    }

    private void LateUpdate()
    {
        round = spawnEnemy.round;
        /*if(life < 0)
        { 
        loseImage.SetActive(true);
        }*/
    }

    void nameText(Text text, string str)
    {
        text.text = str;
    }
}
