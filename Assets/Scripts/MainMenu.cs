using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mask;
    public void LoadLevelsMenu () {
        PlayerPrefs.SetString ("LevelToLoad", "LevelMenu");
        mask.SetActive (true);
    }
    public void Play () {
        PlayerPrefs.SetString ("LevelToLoad", "Level01");
        mask.SetActive (true);
    }
    public void LoadLevel () {
        SceneManager.LoadScene (PlayerPrefs.GetString ("LevelToLoad"));
    }
}
