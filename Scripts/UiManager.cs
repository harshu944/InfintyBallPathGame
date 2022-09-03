using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    public GameObject infiniteballpath;
    public GameObject gameOverPanel;
    public GameObject tapText;
    public GameObject leaderBoardButton;
   
    public Text score;
    public Text highscore1;
    public Text highscore2;


    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        highscore1.text = PlayerPrefs.GetInt("highScore").ToString();

    }

    public void GameStart()
    {
       

        tapText.SetActive(false);
        leaderBoardButton.SetActive(false);
        infiniteballpath.GetComponent<Animator>().Play("PanelUp");
    }
    public void GameOver()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
        highscore2.text = PlayerPrefs.GetInt("highScore").ToString();
        gameOverPanel.SetActive(true);
    }
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
    public void Reset2()
    {
        SceneManager.LoadScene(1);
    }
   
    public void doquit()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }
   
  
    // Update is called once per frame
    void Update()
    {
        
    }
   
}
