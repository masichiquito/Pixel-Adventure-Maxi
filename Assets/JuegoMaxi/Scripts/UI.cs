using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Slider slider;
    public GameObject gameOverPanel;
    public GameObject youWinPanel;
    public GameObject pausePanel;
    void Start()
    {
        gameOverPanel.SetActive(false); 
    }

    public void SetSliderValuer(int health)
    {
        slider.value = health;

    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void Continue()
    {
        pausePanel.SetActive(false);
        ResumeGame();
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Application.Quit");

    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }



    public void Pause()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            pausePanel.SetActive(true);
            PauseGame();
        }

            
    }
    


    // Update is called once per frame
    void Update()
    {
        Pause();
    }
    public void Win()
    {
        youWinPanel.SetActive(true);
    }
}
