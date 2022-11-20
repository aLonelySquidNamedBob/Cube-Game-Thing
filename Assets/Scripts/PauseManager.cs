using UnityEngine;

public class PauseManager : MonoBehaviour {
    public GameObject menuPanel;
    public GameObject menu;
    public GameObject menuMask;

    void Start () {
        ShowUI ();
    }

    void ShowUI () {
        menuPanel.SetActive (true);
        menu.SetActive (true);
    }

    public void HideUI () {
        menuMask.SetActive (true);
    }
}
