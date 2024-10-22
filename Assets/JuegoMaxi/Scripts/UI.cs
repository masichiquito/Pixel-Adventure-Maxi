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
    public AudioSource audioSource;
    public AudioClip audioClipButton;
    public AudioClip audioClipWin;
    public AudioClip audioClipGameOver;
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
        audioSource.PlayOneShot(audioClipGameOver);
    }
    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
    public void Resume()
    {
        pausePanel.SetActive(false);
        ResumeGame();
    }

    public void Exit()
    {
        PlayButtonSound();
        Application.Quit();
        Debug.Log("Application.Quit");
    }

    public void PlayButtonSound()
    {
        audioSource.PlayOneShot(audioClipButton);
    }


    public void PauseGame()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void Level(int level)
    {
        PlayButtonSound();
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene(level);
        
    }




    public void Pause()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
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
        audioSource.PlayOneShot(audioClipWin);
        Time.timeScale = 0;

    }
}
