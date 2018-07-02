using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public LocalScoreRight playerscore;
    public GameObject pauseMenuUI, EndGameScreen, ball;
    public GameObject first;
    public GameObject second;

    public virtual void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }

        if (playerscore.PlayerLeft > 9)
        {
            EndtheGame(first);
        }
        if (playerscore.PlayerRight > 9)
        {
            EndtheGame(second);
        }

        
    }


   public virtual void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public virtual void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Restart()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(1);
    }

    public void LoadMainMenu()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }

    void EndtheGame(GameObject won)
    {
        won.SetActive(true);
        EndGameScreen.SetActive(true);
        Destroy(pauseMenuUI);
        Destroy(ball);
    }
}
