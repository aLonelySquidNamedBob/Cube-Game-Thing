using UnityEngine;

public class Management : MonoBehaviour {

    public Scoring scoring;
    public PlayerMovement player;
    public Transform playerPos;
    public CamMovement cam;
    public GameObject levelCompleteUI;
    public GameObject levelFailedUI;
    public GameObject reloadLevelUI;
    public GameObject levelLoadUI;
    public GameObject levelPauseUI;
    
    public static bool gameOver = false;

    void Start () {
        levelLoadUI.SetActive (true);
        gameOver = false;
    }

    public void GameOver () {
        if (!gameOver) {
            cam.enabled = false;
            scoring.enabled = false;
            player.enabled = false;
            levelFailedUI.SetActive (true);
            gameOver = true;
        }
    }

    public void ReloadLevelUI () {
        reloadLevelUI.SetActive (true);
    }

    public void Win () {
        if (!gameOver) {
            player.enabled = false;
            levelCompleteUI.SetActive (true);
            gameOver = true;
        }
    }

    public void LevelPauseAnim () {
        print (gameOver);
        if (!gameOver) {
            levelPauseUI.SetActive (true);
        }
    }

    public void CollectedCoin () {
        Scoring.coins += 10;
    }
}
