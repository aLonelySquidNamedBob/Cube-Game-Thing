using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    [Range (3000f, 10000f)]
    public float speed = 5000f;
    [Range (10f, 100f)]
    public float sensitivity = 50f;

    bool jumping = false;

    // Update is called once per frame
    void FixedUpdate () {
        rb.AddForce (0, 0, speed * Time.fixedDeltaTime);

        if (transform.position.y < 0.1) {
            jumping = false;
        }

        if (jumping == false) {
            if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey ("d")) {
                rb.AddForce (sensitivity * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey ("a") || Input.GetKey ("q")) {
                rb.AddForce (-sensitivity * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
            }
            
            if (Input.GetKey ("j") && transform.position.y < 0.1 && transform.position.y > -0.1) {
                if (transform.position.x < 8 && transform.position.x > -8) {
                    rb.AddForce (0, 200, 0, ForceMode.Acceleration);
                    jumping = true;
                }
            }
        }

        if (transform.position.y < -0.1) {
            FindObjectOfType<Management> ().GameOver ();
        }
    }
}
