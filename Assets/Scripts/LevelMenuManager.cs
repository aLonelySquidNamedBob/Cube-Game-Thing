using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelMenuManager : MonoBehaviour {

    public GameObject mask;
    public void LoadLevel1 () {
        PlayerPrefs.SetString ("LevelToLoad", "Level01");
        mask.SetActive (true);
    }
    public void LoadLevel2 () {
        PlayerPrefs.SetString ("LevelToLoad", "Level02");
        mask.SetActive (true);
    }
    public void LoadLevel3 () {
        PlayerPrefs.SetString ("LevelToLoad", "Level03");
        mask.SetActive (true);
    }
    public void LoadLevel4 () {
        PlayerPrefs.SetString ("LevelToLoad", "Level04");
        mask.SetActive (true);
    }
    public void LoadLevel5 () {
        PlayerPrefs.SetString ("LevelToLoad", "Level05");
        mask.SetActive (true);
    }
    public void LoadLevel6 () {
        PlayerPrefs.SetString ("LevelToLoad", "Level06");
        mask.SetActive (true);
    }
    public void LoadMainMenu () {
        PlayerPrefs.SetString ("LevelToLoad", "GameMenu");
        mask.SetActive (true);
    }
}
