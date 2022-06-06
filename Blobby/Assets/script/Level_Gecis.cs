using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Gecis : MonoBehaviour
{
    public GameObject paushed;
    public GameObject gameover;
    public GameObject win;

    private void Start()
    {
        paushed.gameObject.SetActive(false);
        Time.timeScale = 1;				//continue the game
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level_1");
        time.times = 60;
        puan.puanlama = 0;
       
    }
    public void pauseTheGame()
    {
        if (Time.timeScale == 1)
        {
            paushed.gameObject.SetActive(true);
            Time.timeScale = 0;				//pause the game
        }
        else if (Time.timeScale == 0)
        {
            paushed.gameObject.SetActive(false);
            Time.timeScale = 1;				//continue the game
        }
    }

    public void Level1donus()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void Pausedmenu2()
    {
        SceneManager.LoadScene(5);
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level_2");
        time.times = 60;
        puan.puanlama = 0;
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level_3");
        time.times = 60;
        puan.puanlama = 0;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            win.SetActive(true); 
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void BacktoMainMenu()
    {
        puan.puanlama = 0;
        SceneManager.LoadScene(0);
       // paushed.gameObject.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Oyunda Çýkýldý");
        Application.Quit();
    }
}
