using UnityEngine;
using UnityEngine.SceneManagement ;

public class GameControl : MonoBehaviour
{
    public GameObject gameOverPanel ;
    public GameObject TapToStart ;
    public GameObject ScoreCard ;
    private void Start()
    {
        ScoreCard.SetActive(false) ;
        gameOverPanel.SetActive(false) ;
        TapToStart.SetActive(true) ;
        PauseGame();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame() ;
        }
    }
    public void GameOver()
    {
        ScoreCard.SetActive(false) ;
        gameOverPanel.SetActive(true) ;
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f ;
    }
    public void StartGame()
    {
        ScoreCard.SetActive(true) ;
        TapToStart.SetActive(false) ;
        Time.timeScale = 1f ;
    }
}
