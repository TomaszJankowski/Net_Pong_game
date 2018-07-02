using UnityEngine;

public class PauseMenuMulti : PauseMenu {


     public override void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
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
    }

    public override void Resume()
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
    }

    public override void Pause()
    {
        pauseMenuUI.SetActive(true);
        GameIsPaused = true;
    }

}
