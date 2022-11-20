using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void RestartFromMenu () {
        SceneManager.LoadScene (0);
    }
    public void LoadFirstLevel () {
        SceneManager.LoadScene (1);
    }

    public void ReloadLevel () {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
    }

    public void LoadNextLevel () {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
    }

    public void LoadPauseScene () {
        PlayerPrefs.SetString ("lastLoadedScene", SceneManager.GetActiveScene ().name);
        SceneManager.LoadScene ("PauseMenu");
    }

    public void LoadPreviousLevel () {
        SceneManager.LoadScene (PlayerPrefs.GetString ("lastLoadedScene"));
    }
}
