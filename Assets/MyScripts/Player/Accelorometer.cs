using UnityEngine;
using System.Collections;

public class Accelorometer : MonoBehaviour {

    public GameObject state;
    public GameObject player;
    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate() {
        StateCheck sc = state.GetComponent<StateCheck>();
        if (sc.isPause == false)
        {
            this.Active();
        }
        else {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
    void Active() {
        float moveForward = +5f;
        float moveSides = Input.acceleration.x * 30;
        Vector3 movement = new Vector3(moveSides, 0.0f, moveForward);
        rb.AddForce(movement * 100f);
    }

}
