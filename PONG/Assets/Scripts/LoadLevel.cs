using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

    public void LoadLocal()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadMulti()
    {
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
