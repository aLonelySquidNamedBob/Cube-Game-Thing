using UnityEngine;

public class CollisionDetection : MonoBehaviour {

    void OnTriggerEnter (Collider colliderInfo) {
        if (colliderInfo.tag == "Win")
            FindObjectOfType<Management> ().Win ();
        if (colliderInfo.tag == "Coin") {
            FindObjectOfType<Management> ().CollectedCoin ();
            Destroy (colliderInfo.gameObject);
        }
    }

    void OnCollisionEnter (Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            FindObjectOfType<Management> ().GameOver ();
        }
    }
}
