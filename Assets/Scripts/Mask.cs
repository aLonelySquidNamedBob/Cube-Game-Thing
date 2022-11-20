using UnityEngine;

public class Mask : MonoBehaviour {
    public GameObject mask;

    public void ShowMask () {
        mask.SetActive (true);
    }

    public void HideMask () {
        mask.SetActive (false);
    }
}
