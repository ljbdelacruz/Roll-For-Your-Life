using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetScore : MonoBehaviour {

    public GameObject player;
    public GameObject Score;
	// Update is called once per frame
	void Update () {
        this.UpdateScore();
	}
    void UpdateScore() {
        this.Score.GetComponent<Text>().text = "" + this.player.GetComponent<player>().score;
    }
}
