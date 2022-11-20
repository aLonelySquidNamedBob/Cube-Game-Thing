using UnityEngine;

public class SetLevelLoadVisibility : MonoBehaviour {
    public GameObject levelLoadUI;

    public void DisActivate () {
        levelLoadUI.SetActive (false);
    }
}
