using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSelectedLevel : MonoBehaviour {
    public void LoadSelectedLevels () {
        SceneManager.LoadScene (PlayerPrefs.GetString ("LevelToLoad"));
    }
}
