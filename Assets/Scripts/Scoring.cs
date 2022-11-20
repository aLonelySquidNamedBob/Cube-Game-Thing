using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {
    public Text scoreText;
    public Transform player;
    int score;
    public static int coins;
    void Start () {
        coins = 0;
    }

    void Update () {
        score = (int)player.position.z / 10 + coins;
        scoreText.text = score.ToString("0");
    }
}
