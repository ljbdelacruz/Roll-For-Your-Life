using UnityEngine;
using System.Collections;

public class Player {
    public int score = 0;
    public AudioSource soundFx;
    public AudioClip[] soundList;


    public Player(){

    }
    public void ChangeSound(int sound) {
        soundFx.clip = soundList[sound];
        soundFx.Play();
    }

}
