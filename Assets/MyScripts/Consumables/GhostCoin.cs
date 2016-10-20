using UnityEngine;
using System.Collections;

public class MagnetCoin : MonoBehaviour {

    public GameObject coin;
    public int duration;
    private bool enableMagnet=false;
    private int time=0;
	// Update is called once per frame
	void Update () {
        if (enableMagnet) {
            if (time < duration)
            {
                this.ActiveMagnet();
            }
            else {
                time = 0;
                enableMagnet = false;
            }
            time++;
        }
	}

    void ActiveMagnet() {

    }
    public void OnTriggerEnter(Collider other)
    {
        //when player touches the coin it disappears
        if (other.gameObject.name == "Player")
        {
            this.enableMagnet = true;
        }
    }


}
