using UnityEngine;
using System.Collections;

public class JumpPowerUps : MonoBehaviour {
    public GameObject player;
    public GameObject PowerUp;
    public float coinRotationSpeed;


	// Update is called once per frame
	void Update () {
        AnimateCoin();
	}
    void AnimateCoin()
    {
        transform.Rotate(0, coinRotationSpeed * Time.deltaTime, 0, Space.World);
    }
    void Jump() {
        Debug.Log("Jump");
        this.player.gameObject.GetComponent<Rigidbody>().AddForce(0, 20, 0, ForceMode.VelocityChange);
        Debug.Log("Finish");
    }

    void SoundFx() {
        this.Jump();
        this.player.GetComponent<player>().ChangeSound(2);
        this.PowerUp.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        //when player touches the coin it disappears
        if (other.gameObject.name == "Player")
        {
            this.SoundFx();
        }
    }
    public void OnTriggerStay(Collider other)
    {
        //when player touches the coin it disappears
        if (other.gameObject.name == "Player")
        {
            this.SoundFx();
        }
    }
    public void OnTriggerExit(Collider other)
    {
        //when player touches the coin it disappears
        if (other.gameObject.name == "Player")
        {
            this.SoundFx();
        }
    }

}
