using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour
{

    public GameObject player;
    public GameObject coin;
    public float coinRotationSpeed;
    public int value;

    // Update is called once per frame
    void Update()
    {
        AnimateCoin();
    }
    void AnimateCoin() {
        transform.Rotate(0, coinRotationSpeed * Time.deltaTime, 0, Space.World);
    }


    void DestroyCoin() {
        this.player.GetComponent<player>().increaseScore(this.value);
        this.player.GetComponent<player>().ChangeSound(1);
        this.coin.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player") {
            this.DestroyCoin();
        }
    }
    public void OnTriggerStay(Collider other) {
        if (other.gameObject.name == "Player")
        {
            this.DestroyCoin();
        }
    }
    public void OnTriggerExit(Collider other) {
        if (other.gameObject.name == "Player" )
        {
            this.DestroyCoin();
        }
    }

}