using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    public Text countDownText;
    public float countDown;
    
    public Health playerHealth;
    public HeadRock rockHeadBoss;
    private bool isOneFrame = true;

    public UI ui;

    // Start is called before the first frame update
    void Start()
    {
         countDownText.text = countDown.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        CountDown();
        LooseCondition();
        WinConidition();
    }

    private void CountDown()
    {
        if (countDown > 0)
        {
            countDown -= Time.deltaTime;
            TimeSpan countDonwSeconds = TimeSpan.FromSeconds(countDown);
            countDownText.text = countDonwSeconds.ToString(@"mm\:ss");
        }

    }

    private void LooseCondition()
    {
        bool playerIsDie = playerHealth.health <= 0;
        bool timeIsOver = countDown <= 0;

        if ((playerIsDie || timeIsOver) && isOneFrame)
        {
            isOneFrame = false;
            countDown = 0;

            DeactivateHeadRockBoss();
            playerHealth.Damage(100);
        }
    }
    private void DeactivateHeadRockBoss()
    {
        rockHeadBoss.enabled = false;
        rockHeadBoss.GetComponent<BoxCollider2D>().enabled = false;
    }

    private void WinConidition()
    {
        bool playerIsAlive = playerHealth.health > 0;
        bool bossIsDead = rockHeadBoss.health <= 0;
        bool bossIsDestroy = rockHeadBoss == null;

        if (playerIsAlive & bossIsDead & isOneFrame & bossIsDestroy)
        {
            isOneFrame = false;
            ui.Win();       
        }
    }
}
