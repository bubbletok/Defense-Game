using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSetting : MonoBehaviour
{
    public int maximumRound, life, getTower, stage;
    public float gold;
    public Text roundText;
    public Text goldText;
    public Text timeText;
    public Text winText;
    public Text lifeText;
    public GameObject loseImage, winUI;
    public GameObject[] tower;

    int round, towerCount;

    SpawnEnemy spawnEnemy;
    UserSetting userSetting;
    void Start()
    {
        towerCount = 6;
        spawnEnemy = GameObject.Find("SpawnPosition").GetComponent<SpawnEnemy>();
        userSetting = GameObject.Find("UserSetting").GetComponent<UserSetting>();
        for (int i = 0; i < towerCount; i++)
        {
            if (userSetting.Tower[i])
                tower[i].SetActive(true);
        }

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
                winUI.SetActive(true);
                userSetting.Tower[getTower] = true;
                userSetting.stageClear[stage] = true;
                //-> click next button -> MainMenu
                //-> get reward(materials, tower, etc)
            }
        }
    }

    private void LateUpdate()
    {
        round = spawnEnemy.round;
        if(life <= 0)
        {
            life = 0;
            loseImage.SetActive(true);
        }
    }

    void nameText(Text text, string str)
    {
        text.text = str;
    }
}
