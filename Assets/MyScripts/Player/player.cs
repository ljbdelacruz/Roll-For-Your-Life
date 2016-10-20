using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

    public int score;
    public bool enableWallDestroy = false;
    public AudioSource soundFx;
    public AudioClip[] soundList;


    // Use this for initialization
    void Start () {
        score = 0;
	}
	// Update is called once per frame
	void Update () {
        
	}
    public void increaseScore(int point) {
        score+=point;
    }

    //power ups
    public void WallDestroyerActive() {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Fence_1" || col.gameObject.name == "Fence_0") {

        }
    }
    public void ChangeSound(int sound)
    {
        soundFx.clip = soundList[sound];
        soundFx.Play();
    }

}
